
using System;
using UnityEngine;

namespace HGrandry.Injection
{
    public static partial class InjectionAPI
    {       
        #region Require

        /// <summary>
        /// Require services of type T1, T2
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        public static void Require<T1, T2>(this MonoBehaviour component, Func<T1, T2, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2>(component, (x1, x2) =>
            {
                var dispose = receive(x1, x2);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        public static void Require<T1, T2, T3>(this MonoBehaviour component, Func<T1, T2, T3, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3>(component, (x1, x2, x3) =>
            {
                var dispose = receive(x1, x2, x3);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        public static void Require<T1, T2, T3, T4>(this MonoBehaviour component, Func<T1, T2, T3, T4, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4>(component, (x1, x2, x3, x4) =>
            {
                var dispose = receive(x1, x2, x3, x4);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        public static void Require<T1, T2, T3, T4, T5>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5>(component, (x1, x2, x3, x4, x5) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6>(component, (x1, x2, x3, x4, x5, x6) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7>(component, (x1, x2, x3, x4, x5, x6, x7) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8>(component, (x1, x2, x3, x4, x5, x6, x7, x8) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable
            where T14 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);
                OnResolved(component);
                return dispose;
            });
        }

        /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15
        /// </summary>
        /// <param name="component">The component requiring the services</param>
        /// <param name="receive">Called when all dependencies are solved, and return a cleanup action called when the component gets invalidated (one dependency get missing) or when the component is destroyed</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this MonoBehaviour component, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Action> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable
            where T14 : class, IInjectable
            where T15 : class, IInjectable   
        {
            OnRequire(component);

            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
            {
                var dispose = receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);
                OnResolved(component);
                return dispose;
            });
        }

        #endregion

        #region Require, variants with no cleanup method

        /// <summary>
        /// Require services of type T1, T2
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        public static void Require<T1, T2>(this MonoBehaviour component, Action<T1, T2> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2>(component, (x1, x2) =>
            {
                receive(x1, x2);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        public static void Require<T1, T2, T3>(this MonoBehaviour component, Action<T1, T2, T3> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3>(component, (x1, x2, x3) =>
            {
                receive(x1, x2, x3);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        public static void Require<T1, T2, T3, T4>(this MonoBehaviour component, Action<T1, T2, T3, T4> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4>(component, (x1, x2, x3, x4) =>
            {
                receive(x1, x2, x3, x4);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        public static void Require<T1, T2, T3, T4, T5>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5>(component, (x1, x2, x3, x4, x5) =>
            {
                receive(x1, x2, x3, x4, x5);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6>(component, (x1, x2, x3, x4, x5, x6) =>
            {
                receive(x1, x2, x3, x4, x5, x6);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7>(component, (x1, x2, x3, x4, x5, x6, x7) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8>(component, (x1, x2, x3, x4, x5, x6, x7, x8) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable
            where T14 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14);
                OnResolved(component);
                return null;
            });
        }

         /// <summary>
        /// Require services of type T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15
        /// </summary>
        /// <param name="component">The component requiring the service</param>
        /// <param name="receive">Called when all dependencies are solved</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        public static void Require<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this MonoBehaviour component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> receive) 
            where T1 : class, IInjectable
            where T2 : class, IInjectable
            where T3 : class, IInjectable
            where T4 : class, IInjectable
            where T5 : class, IInjectable
            where T6 : class, IInjectable
            where T7 : class, IInjectable
            where T8 : class, IInjectable
            where T9 : class, IInjectable
            where T10 : class, IInjectable
            where T11 : class, IInjectable
            where T12 : class, IInjectable
            where T13 : class, IInjectable
            where T14 : class, IInjectable
            where T15 : class, IInjectable   
        {
            OnRequire(component);
            
            var hook = component.gameObject.AddComponent<DependencyHook>();
            hook.Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(component, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
            {
                receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15);
                OnResolved(component);
                return null;
            });
        }

        
        #endregion
    }
}