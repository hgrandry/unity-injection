using System;
using UnityEngine;

namespace HGrandry.Injection
{
    internal class ConsumerRef : IConsumer
    {
        private readonly MonoBehaviour _component;
        
        public Action InvalidateCallback { get; set; }
        
        public ConsumerRef(MonoBehaviour component)
        {
            _component = component;
        }
            
        public void Invalidate()
        {
            InvalidateCallback?.Invoke();
        }

        public Type GetTargetType()
        {
            return _component.GetType();
        }

        public bool IsAlive => _component != null;
    }
}