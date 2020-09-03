using System;
using UnityEngine;

namespace HGrandry.Injection
{
    public partial class DependencyHook : MonoBehaviour
    {
        [SerializeField][HideInInspector] private DependencyHookInternal _internal;

        public void Initialize<T>(MonoBehaviour target, Func<T, Action> receive)
            where T : class
        {
            _internal = new DependencyHookInternal<T>(target, receive);
            _internal.Enable();
        }

        private void OnDestroy()
        {
            _internal?.Disable();
        }

        abstract class DependencyHookInternal : IConsumer
        {
            private readonly MonoBehaviour _target;
            private Action _invalidate;
            private bool _isResolved;

            public bool IsAlive => _target != null && _target.gameObject != null;

            protected DependencyHookInternal(MonoBehaviour target)
            {
                _target = target;
            }

            protected void MarkAsResolved()
            {
                _isResolved = true;
            }

            public abstract void Enable();

            public void Disable()
            {
                DependencySolver.RemoveDependencies(this);
                Invalidate();
            }

            protected void OnValidated(Action invalidate)
            {
                _invalidate = invalidate;
            }

            public void Invalidate()
            {
                if (!_isResolved)
                    return;

                _isResolved = false;

                _invalidate?.Invoke();
            }

            Type IConsumer.GetTargetType()
            {
                return _target.GetType();
            }

            public override string ToString()
            {
                return _target.ToString();
            }
        }

        sealed class DependencyHookInternal<T> : DependencyHookInternal
            where T : class
        {
            private readonly Func<T, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T>(this, x =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x));
                });
            }
        }
    }
}