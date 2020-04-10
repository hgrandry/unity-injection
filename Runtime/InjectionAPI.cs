using System;
using UnityEngine;

namespace HGrandry.Injection
{
    /// <summary>
    /// API to share and access objects across the application.
    /// Add an object to the DependencySolver once its initialized and only if it needs to be shared with the rest of the application.
    /// Don't forget to unregister your shared object on destroy.
    /// Access shared objects asynchronously with Request() or synchronously with Get() / GetOrCreate(). Synchronous call might return null (i.e the object is not registered yet), whereas asynchronous request only return the value when the object is created (callbacks).
    /// </summary>
    public static partial class InjectionAPI
    {
        private static void OnRequire(Component component)
        {
            if (component is IInjectable)
                component.gameObject.SetActive(false);
        }
        
        private static void OnResolved(Component component)
        {
            if (component is IInjectable)
                component.gameObject.SetActive(true);
        }
        
        #region Require

        /// <summary>
        /// Require a service of type T
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T"></typeparam>
        public static void Require<T>(this MonoBehaviour component, Func<T, Action> receive) where T : class, IInjectable
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T>(component, x =>
            {
                var dispose = receive(x);
                OnResolved(component);
                return dispose;
            });
        }
        
        #endregion

        #region Require, variants with no cleanup method

        /// <summary>
        /// Require a service of type T
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T"></typeparam>
        public static void Require<T>(this MonoBehaviour component, Action<T> receive) where T : class, IInjectable
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T>(component, x =>
            {
                receive(x);
                OnResolved(component);
                return null;
            });
        }
        
        #endregion
        
        #region Get / Try get service. Syncronous
        
        /// <summary>
        /// Access a registered object of type T synchronously. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        /// <returns>Return the object is registered or null.</returns>
        public static T GetService<T>(this MonoBehaviour component) where T: class, IInjectable
        {
            return DependencySolver.GetRegistered<T>();
        }

        /// <summary>
        /// Safely access a registered object of type T synchronously. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        /// <param name="service"></param>
        /// <returns>Return the object is registered or null.</returns>
        public static bool TryGetService<T>(this MonoBehaviour component, out T service) where T: class, IInjectable
        {
            service = DependencySolver.GetRegistered<T>();
            return service != null;
        }

        #endregion

        #region Register

        public static void RegisterAsService<T>(this T service) where T: MonoBehaviour, IInjectable
        {
            GameObject go = service.gameObject;
            var isActive = go.activeSelf;
            go.SetActive(false);
            var hook = go.GetOrCreateComponent<InjectableHook>();
            hook.Initialize(service);
            go.SetActive(isActive);
        }
        
        /// <summary>
        /// Register an object of type T.
        /// An object should be registered when it need to be shared with the rest of the application and it is ready to use (i.e initialised).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        /// <param name="service"></param>
        public static void Register<T>(this MonoBehaviour component, T service) where T: class, IInjectable
        {
            Register<T, T>(component, service, typeof(T));
        }

        /// <summary>
        /// Register the calling component as an object of type T.
        /// An object should be registered when it need to be shared with the rest of the application and it is ready to use (i.e initialised).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param> 
        public static void Register<T>(this T component) where T: class, IInjectable
        {
            Register<T, T>(component as MonoBehaviour, component, typeof(T));
        }

        /// <summary>
        /// Register an object and associate it to a given type.
        /// An object should be registered when it need to be shared with the rest of the application and it is ready to use (i.e initialised).
        /// </summary>
        /// <param name="component"></param>
        /// <param name="service"></param>
        /// <param name="type"></param>
        public static void Register<TService, TRegisterAs>(this MonoBehaviour component, TService service, Type type)
            where TService: class, TRegisterAs
            where TRegisterAs: IInjectable
        {
            DependencySolver.Register<TService, TRegisterAs>(service, type);
        } 

        #endregion

        #region Unregister

        /// <summary>
        /// Remove an object of type T from the DependencySolver.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        /// <param name="service"></param>
        public static void Unregister<T>(this MonoBehaviour component, T service) where T: class, IInjectable
        {
            DependencySolver.Unregister<T, T>(service);
        }

        /// <summary>
        /// Remove the calling component from the DependencySolver using the type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="component"></param>
        public static void Unregister<T>(this T component) where T: class, IInjectable
        {
            Unregister(component as MonoBehaviour, component);
        }

        /// <summary>
        /// Remove an object from the DependencySolver using the provided type.
        /// </summary>
        /// <param name="component"></param>
        /// <param name="service"></param>
        /// <param name="type"></param>
        public static void Unregister<TService, TRegisterAs>(this IConsumer component, TService service, Type type)
            where TService : class, TRegisterAs
            where TRegisterAs : class, IInjectable
        {
            DependencySolver.Unregister<TService, TRegisterAs>(service);
        } 

        #endregion
    }
}