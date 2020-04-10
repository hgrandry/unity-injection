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
        private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();
        private static readonly Dictionary<Type, HashSet<Dependency>> DependenciesByType = new Dictionary<Type, HashSet<Dependency>>();
        private static readonly Dictionary<IConsumer, Dependency> DependenciesByComponent = new Dictionary<IConsumer, Dependency>();
        private static readonly List<IConsumer> _toRemove = new List<IConsumer>();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void Initialize()
        {
            Services.Clear();
            DependenciesByType.Clear();
            DependenciesByComponent.Clear();
            _toRemove.Clear();
            
            SceneManager.sceneUnloaded -= Sanitize;
            SceneManager.sceneUnloaded += Sanitize;
        }

        private static void Sanitize(Scene scene)
        {
            foreach (var consumer in DependenciesByComponent.Keys)
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

        private abstract class Dependency
        {
            public readonly IConsumer Consumer;
            protected readonly Dictionary<Type, object> Dependencies = new Dictionary<Type, object>();
            internal readonly Type[] Types;

            internal bool IsResolved { get; private set; }
            
            public bool HasResolved(Type type)
            {
                Dependencies.TryGetValue(type, out object dependency);
                return dependency != null;
            }

            protected Dependency(IConsumer consumer, params Type[] types)
            {
                Types = types;

                Consumer = consumer;
                // Component.Deactivate(); // restore this?

                foreach (Type type in types)
                {
                    Dependencies[type] = null;
                }
            }

            public void Receive<T>(T dependency, Type type)
            {
                if (!Dependencies.ContainsKey(type))
                    return;

                Dependencies[type] = dependency;

                if (Dependencies.Values.Any(x => x == null)) 
                    return;
                
                OnResolved();
                IsResolved = true;
            }

            public void Return<T>()
            {
                var type = typeof(T);
                if (!Dependencies.ContainsKey(type))
                    return;

                Dependencies[type] = null;
                IsResolved = false;
#if UNITY_EDITOR
                if (ApplicationHelper.IsStopping)
                    return;
#endif
                Consumer?.Invalidate();
            }

            protected abstract void OnResolved();
        }

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
        
        #region Require

        internal static void Require<T>(IConsumer component, Action<T> receive) where T : class, IInjectable
        {
            if (DependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T>(component, receive);
            DependenciesByComponent[component] = dependency;

            var type = typeof(T);
            OnNewDependency(type, dependency);
        }

        private static void OnNewDependency(Type type, Dependency dependency)
        {
            if (!DependenciesByType.TryGetValue(type, out HashSet<Dependency> list))
            {
                list = new HashSet<Dependency>();
                DependenciesByType[type] = list;
            }

            list.Add(dependency);

            if (Services.ContainsKey(type))
            {
                dependency.Receive(Services[type], type);
            }
        }

        internal static void RemoveDependencies(IConsumer component)
        {
            if (!DependenciesByComponent.TryGetValue(component, out Dependency dependency))
                return;

            foreach (Type type in dependency.Types)
            {
                HashSet<Dependency> list = DependenciesByType[type];
                list.Remove(dependency);
            }

            DependenciesByComponent.Remove(component);
        }

        internal static T GetRegistered<T>() where T : class, IInjectable
        {
            Type type = typeof(T);

            if (!Services.TryGetValue(type, out object service))
                return null;

            return service as T;
        }

        #endregion

        #region Register

        internal static void Register<T>(T service) where T : class, IInjectable
        {
            Register<T, T>(service, service.GetType());
        }

        internal static void RegisterAs<TService, TRegisterAs>(TService service)
            where TService : class, TRegisterAs
            where TRegisterAs : IInjectable
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
            where TRegisterAs : IInjectable
        {
            if (Services.ContainsKey(type))
            {
                Debug.LogWarning("A service of type " + type.Name + " is already registered.");
                return;
            }

            // register the service
            Services[type] = service;

            // provide service to awaiting consumers

            if (!DependenciesByType.TryGetValue(type, out HashSet<Dependency> dependencies))
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
            where TRegisterAs : class, IInjectable
        {
            Type type = typeof(TRegisterAs);

            if (!Services.Remove(type))
                return;

            if (!DependenciesByType.TryGetValue(type, out HashSet<Dependency> dependencies)) 
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
            if (!DependenciesByComponent.TryGetValue(component, out Dependency dependency))
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
            foreach (Type type in Services.Keys.OrderBy(x => x.Name))
            {
                s.AppendLine(type.Name);
            }
            s.AppendLine();

            // unresolved

            IEnumerable<Dependency> unresolved = DependenciesByComponent.Values.Where(x => !x.IsResolved);
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
            
            var resolvedDependencies = DependenciesByComponent.Values.Where(x => x.IsResolved);
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