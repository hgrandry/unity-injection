using UnityEngine;

namespace HGrandry.Injection
{
    /// <summary>
    /// Add this interface to any object that need to be shared in the register.
    /// Although it doesn't require to implement any property,
    /// the interface benefit is to track in the project what are objects can be added and retrieve from the register.
    /// (i.e, you can't call Request() of a type that does not implement IRegister)
    /// </summary>
    public interface IInjectable
    {
    }

    /// <summary>
    /// Register the component as T, instead of using the component derived type.
    /// For instance: class MyNetwork : RegisteredComponent<INetwork> will register as a INetwork, not a MyNetwork.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Injectable<T> : MonoBehaviour, IInjectable where T : class, IInjectable
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