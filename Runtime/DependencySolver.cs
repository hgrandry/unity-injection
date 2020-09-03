using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace HGrandry.Injection
{
    public interface IConsumer
    {
        // Called on active object (i.e object that have all their dependency solved) when one dependency get missing.
        void Invalidate();
        
        // For debug purposes
        Type GetTargetType();
        
        bool IsAlive { get;  }
    }
    
    public static partial class DependencySolver
    {
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();
        private static readonly Dictionary<Type, HashSet<Dependency>> _dependenciesByType = new Dictionary<Type, HashSet<Dependency>>();
        private static readonly Dictionary<IConsumer, Dependency> _dependenciesByComponent = new Dictionary<IConsumer, Dependency>();
        private static readonly List<IConsumer> _toRemove = new List<IConsumer>();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void Initialize()
        {
            Reset();

            SceneManager.sceneUnloaded -= Sanitize;
            SceneManager.sceneUnloaded += Sanitize;
        }

        public static void Reset()
        {
            _services.Clear();
            _dependenciesByType.Clear();
            _dependenciesByComponent.Clear();
            _toRemove.Clear();
        }

        private static void Sanitize(Scene scene)
        {
            foreach (var consumer in _dependenciesByComponent.Keys)
            {
                if(!consumer.IsAlive)
                    _toRemove.Add(consumer);
            }
            
            if(!_toRemove.Any())
                return;

            foreach (IConsumer consumer in _toRemove)
            {
                RemoveDependencies(consumer);
            }
            _toRemove.Clear();
        }

        #region Dependency

        private class Dependency<T> : Dependency
        {
            private readonly Action<T> _receive;

            public Dependency(IConsumer consumer, Action<T> receive)
                : base(consumer, typeof(T))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T) Dependencies[typeof(T)]);
            }
        }

        #endregion
        
        #region Inject

        internal static void Inject<T>(IConsumer component, Action<T> receive) where T : class
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T>(component, receive);
            _dependenciesByComponent[component] = dependency;

            var type = typeof(T);
            AddDependency(type, dependency);
        }

        internal static void AddDependency(Dependency dependency)
        {
            foreach (Type type in dependency.Types)
            {
                AddDependency(type, dependency);
            }
        }

        internal static void AddDependency(Type type, Dependency dependency)
        {
            if (!_dependenciesByType.TryGetValue(type, out HashSet<Dependency> list))
            {
                list = new HashSet<Dependency>();
                _dependenciesByType[type] = list;
            }

            list.Add(dependency);

            if (_services.ContainsKey(type))
            {
                dependency.Receive(_services[type], type);
            }
        }

        internal static void RemoveDependencies(IConsumer component)
        {
            if (!_dependenciesByComponent.TryGetValue(component, out Dependency dependency))
                return;

            RemoveDependency(dependency);
        }
        
        internal static void RemoveDependency(Dependency dependency)
        {
            if(ApplicationHelper.IsStopping)
                return;
            
            if(dependency == null)
                return;
            
            foreach (Type type in dependency.Types)
            {
                if (!_dependenciesByType.ContainsKey(type)) 
                    continue;
                HashSet<Dependency> list = _dependenciesByType[type];
                list.Remove(dependency);
            }

            _dependenciesByComponent.Remove(dependency.Consumer);
        }

        public static T GetService<T>() where T : class
        {
            Type type = typeof(T);

            if (!_services.TryGetValue(type, out object service))
                return null;

            return service as T;
        }

        #endregion

        #region Register

        internal static void Register<T>(T service) where T : class
        {
            Register<T, T>(service, service.GetType());
        }

        internal static void RegisterAs<TService, TRegisterAs>(TService service)
            where TService : class, TRegisterAs
        {
            Register<TService, TRegisterAs>(service, typeof(TRegisterAs));
        }

        /// <summary>
        /// Register the object as a service of the given type
        /// </summary>
        /// <param name="service">The object supporting the service</param>
        /// <param name="type">The type of service</param>
        internal static void Register<TService, TRegisterAs>(TService service, Type type)
            where TService : class, TRegisterAs
        {
            if (_services.ContainsKey(type))
            {
                Debug.LogWarning("A service of type " + type.Name + " is already registered.");
                return;
            }

            // register the service
            _services[type] = service;

            // provide service to awaiting consumers

            if (!_dependenciesByType.TryGetValue(type, out HashSet<Dependency> dependencies))
                return;
            
            foreach (Dependency dependency in dependencies.ToArray())
            {
                dependency.Receive<TRegisterAs>(service, typeof(TRegisterAs));
            }
        }

        #endregion

        #region Unregister

        internal static void Unregister<TService, TRegisterAs>(TService service)
            where TService : class, TRegisterAs
            where TRegisterAs : class
        {
            Type type = typeof(TRegisterAs);

            if (!_services.Remove(type))
                return;

            if (!_dependenciesByType.TryGetValue(type, out HashSet<Dependency> dependencies)) 
                return;
            
            foreach (Dependency dependency in dependencies.ToArray())
            {
                dependency.Return<TRegisterAs>();
            }
        }

        #endregion

        #region Debug

        public static IEnumerable<Type> GetUnresolvedDependencies(IConsumer component)
        {
            if (!_dependenciesByComponent.TryGetValue(component, out Dependency dependency))
                yield break;

            if (dependency.IsResolved)
                yield break;

            foreach (Type type in dependency.Types)
            {
                if (!dependency.HasResolved(type))
                    yield return type;
            }
        }
        
#if UNITY_EDITOR
        [MenuItem("Tools/Dependencies/Log dependency solver state")]
#endif
        public static void LogState()
        {
            var s = new StringBuilder();
            var lines = new HashSet<string>();

            // services
            
            s.AppendLine("Currently registered services:");
            foreach (Type type in _services.Keys.OrderBy(x => x.Name))
            {
                s.AppendLine(type.Name);
            }
            s.AppendLine();

            // unresolved

            IEnumerable<Dependency> unresolved = _dependenciesByComponent.Values.Where(x => !x.IsResolved);
            foreach (Dependency dependency in unresolved)
            {
                var typeName = dependency.Consumer.GetTargetType().Name;

                foreach (Type type in dependency.Types)
                {
                    lines.Add(type.Name + " is required by " + typeName);
                }
            }

            if (lines.Any())
            {
                s.AppendLine("Required services that are not registered:");
                foreach (var type in lines)
                {
                    s.AppendLine(type);
                }

                s.AppendLine();
            }

            // resolved
            
            s.AppendLine("Currently consuming services:");
            lines.Clear();
            
            var resolvedDependencies = _dependenciesByComponent.Values.Where(x => x.IsResolved);
            foreach (var dependency in resolvedDependencies)
            {
                var typeName = dependency.Consumer.GetTargetType().Name;
                
                lines.Add($"{typeName} is using...\n\t{string.Join(",\n\t", dependency.Types.Select(type => type.Name).ToArray())}.");
            }

            foreach (var line in lines)
            {
                s.AppendLine(line);
            }

            Debug.Log(s.ToString());
        }
        #endregion
    }
}