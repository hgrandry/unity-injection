using UnityEngine;

namespace HGrandry.Injection
{
    /// <summary>
    /// Register the component as T, instead of using the component derived type.
    /// For instance: class MyNetwork : RegisteredComponent<INetwork> will register as a INetwork, not a MyNetwork.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Injectable<T> : MonoBehaviour, IEnabledWhenReady where T : class
    {
        private bool _registered;

        protected virtual void OnEnable()
        {
            if (_registered)
                return;

            this.Register<T, T>(this as T, typeof(T));
            _registered = true;
        }

        protected virtual void OnDisable()
        {
            if (!_registered)
                return;

            this.Unregister(this as T);
            _registered = false;
        }
    }
}