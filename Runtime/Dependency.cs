using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HGrandry.Injection
{
    internal abstract class Dependency
    {
        internal readonly IConsumer Consumer;
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

            if (IsResolved)
            {
                Debug.LogWarning($"{Consumer.GetTargetType()} dependencies already resolved.");
                return;
            }
            
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

            if (ApplicationHelper.IsStopping)
                return;

            Consumer?.Invalidate();
        }

        protected abstract void OnResolved();
    }
}