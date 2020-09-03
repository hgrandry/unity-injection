using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace HGrandry.Injection
{
    abstract class ReflectionDependencyBase : Dependency
    {
        private readonly Dictionary<Type, FieldInfo> _fieldMap;
        protected readonly MonoBehaviour Component;
        public abstract void Invalidate();

        protected ReflectionDependencyBase(MonoBehaviour component, IConsumer consumer, Dictionary<Type, FieldInfo> fieldMap)
            : base(consumer, fieldMap.Keys.ToArray())
        {
            Component = component;
            _fieldMap = fieldMap;
        }

        protected void AssignFieldValues()
        {
            foreach (KeyValuePair<Type, object> pair in Dependencies)
            {
                var type = pair.Key;
                var service = pair.Value;
                
                if(!_fieldMap.TryGetValue(type, out FieldInfo field))
                    continue;
                
                field.SetValue(Component, service);
            }
        }
    }
    
    internal class ReflectionDependency : ReflectionDependencyBase
    {
        private readonly Action _onResolved;

        public ReflectionDependency(MonoBehaviour component, IConsumer consumer,  Action onResolved, Action onInvalidated, Dictionary<Type, FieldInfo> fieldMap) 
            : base(component, consumer, fieldMap)
        {
            _onResolved = onResolved;
            InjectionAPI.OnRequire(component);
        }

        protected override void OnResolved()
        {
            AssignFieldValues();
            _onResolved?.Invoke();
            InjectionAPI.OnResolved(Component);
        }

        public override void Invalidate()
        {
        }
    }
    
    internal class ReflectionDependencyWithInvalidation : ReflectionDependencyBase
    {
        private readonly Func<Action> _onResolved;
        private readonly MonoBehaviour _component;
        private Action _invalidate;

        public ReflectionDependencyWithInvalidation(MonoBehaviour component, IConsumer consumer, Func<Action> onResolved, Dictionary<Type, FieldInfo> fieldMap) 
            : base(component, consumer, fieldMap)
        {
            _onResolved = onResolved;
            
            InjectionAPI.OnRequire(component);
        }

        protected override void OnResolved()
        {
            AssignFieldValues();
            _invalidate = _onResolved?.Invoke();
            InjectionAPI.OnResolved(Component);
        }

        public override void Invalidate()
        {
            _invalidate?.Invoke();
        }
    }
}