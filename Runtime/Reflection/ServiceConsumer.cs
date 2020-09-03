using UnityEngine;

namespace HGrandry.Injection
{
    public abstract class ServiceConsumer<T> : MonoBehaviour, IEnabledWhenReady where T: MonoBehaviour
    {
        protected void Awake()
        {
            (this as T).Inject(OnServicesResolved, OnInvalidated);
        }

        protected virtual void OnServicesResolved()
        {
            
        }

        protected virtual void OnInvalidated()
        {
            
        }
    }
}