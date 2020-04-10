using UnityEngine;

namespace HGrandry.Injection
{
    public class InjectableHook : MonoBehaviour, IInjectable
    {
        private IWrapper _wrapper;

        interface IWrapper
        {
            void Register();
            void Unregister();
        }   
        
        class Wrapper<T> : IWrapper where T : MonoBehaviour, IInjectable
        {
            private bool _registered;
            private readonly T _service;

            public Wrapper(T service)
            {
                _service = service;
            }

            public void Register()
            {
                if (_registered)
                    return;

                DependencySolver.Register<T, T>(_service, typeof(T));
                _registered = true;
            }

            public void Unregister()
            {
                if (!_registered)
                    return;

                DependencySolver.Unregister<T, T>(_service);
                _registered = false;
            }
        }

        public void Initialize<T>(T service)  where T : MonoBehaviour, IInjectable
        {
            _wrapper = new Wrapper<T>(service);
        }
        
        private void OnEnable()
        {
            _wrapper.Register();
        }

        private void OnDisable()
        {
            _wrapper.Unregister();
        }
    }
}