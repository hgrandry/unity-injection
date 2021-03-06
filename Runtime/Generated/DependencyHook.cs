
using System;
using UnityEngine;

namespace HGrandry.Injection
{
    public partial class DependencyHook
    {
       public void Initialize<T1, T2>(MonoBehaviour target, Func<T1, T2, Action> receive)
            where T1 : class
            where T2 : class            
       {
           _internal = new DependencyHookInternal<T1, T2>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3>(MonoBehaviour target, Func<T1, T2, T3, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4>(MonoBehaviour target, Func<T1, T2, T3, T4, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class
            where T14 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(target, receive);
           _internal.Enable();
       } 

       public void Initialize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Action> receive)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class
            where T14 : class
            where T15 : class            
       {
           _internal = new DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(target, receive);
           _internal.Enable();
       } 



        sealed class DependencyHookInternal<T1, T2> : DependencyHookInternal
            where T1 : class
            where T2 : class   
        {
            private readonly Func<T1, T2, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2>(this, (x1, x2) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class   
        {
            private readonly Func<T1, T2, T3, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3>(this, (x1, x2, x3) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class   
        {
            private readonly Func<T1, T2, T3, T4, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4>(this, (x1, x2, x3, x4) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5>(this, (x1, x2, x3, x4, x5) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6>(this, (x1, x2, x3, x4, x5, x6) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7>(this, (x1, x2, x3, x4, x5, x6, x7) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8>(this, (x1, x2, x3, x4, x5, x6, x7, x8) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class
            where T14 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14));
                });
            }
        }        

        sealed class DependencyHookInternal<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : DependencyHookInternal
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
            where T13 : class
            where T14 : class
            where T15 : class   
        {
            private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Action> _receive;

            public DependencyHookInternal(MonoBehaviour target, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Action> receive)
                : base(target)
            {
                _receive = receive;
            }

            public override void Enable()
            {
                DependencySolver.Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this, (x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15) =>
                {
                    MarkAsResolved();
                    OnValidated(_receive(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15));
                });
            }
        }        
    }
}