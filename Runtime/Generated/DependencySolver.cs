
using System;

namespace HGrandry.Injection
{   
    public static partial class DependencySolver
    {
        #region Dependency
        private class Dependency<T1, T2> : Dependency
        {
            private readonly Action<T1, T2> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2> receive)
                : base(consumer, typeof(T1), typeof(T2))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)]);
            }
        }

        private class Dependency<T1, T2, T3> : Dependency
        {
            private readonly Action<T1, T2, T3> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)]);
            }
        }

        private class Dependency<T1, T2, T3, T4> : Dependency
        {
            private readonly Action<T1, T2, T3, T4> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)], 
						 (T11) Dependencies[typeof(T11)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)], 
						 (T11) Dependencies[typeof(T11)], 
						 (T12) Dependencies[typeof(T12)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)], 
						 (T11) Dependencies[typeof(T11)], 
						 (T12) Dependencies[typeof(T12)], 
						 (T13) Dependencies[typeof(T13)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)], 
						 (T11) Dependencies[typeof(T11)], 
						 (T12) Dependencies[typeof(T12)], 
						 (T13) Dependencies[typeof(T13)], 
						 (T14) Dependencies[typeof(T14)]);
            }
        }

        private class Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : Dependency
        {
            private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _receive;

            public Dependency(IConsumer consumer, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> receive)
                : base(consumer, typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15))
            {
                _receive = receive;
            }

            protected override void OnResolved()
            {
                _receive((T1) Dependencies[typeof(T1)], 
						 (T2) Dependencies[typeof(T2)], 
						 (T3) Dependencies[typeof(T3)], 
						 (T4) Dependencies[typeof(T4)], 
						 (T5) Dependencies[typeof(T5)], 
						 (T6) Dependencies[typeof(T6)], 
						 (T7) Dependencies[typeof(T7)], 
						 (T8) Dependencies[typeof(T8)], 
						 (T9) Dependencies[typeof(T9)], 
						 (T10) Dependencies[typeof(T10)], 
						 (T11) Dependencies[typeof(T11)], 
						 (T12) Dependencies[typeof(T12)], 
						 (T13) Dependencies[typeof(T13)], 
						 (T14) Dependencies[typeof(T14)], 
						 (T15) Dependencies[typeof(T15)]);
            }
        }

   
        #endregion
        
        #region Inject
     
        internal static void Inject<T1, T2>(IConsumer component, Action<T1, T2> receive)
			 where T1 : class
			 where T2 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);
        }

        internal static void Inject<T1, T2, T3>(IConsumer component, Action<T1, T2, T3> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);
        }

        internal static void Inject<T1, T2, T3, T4>(IConsumer component, Action<T1, T2, T3, T4> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class
			 where T4 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5>(IConsumer component, Action<T1, T2, T3, T4, T5> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class
			 where T4 : class
			 where T5 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6>(IConsumer component, Action<T1, T2, T3, T4, T5, T6> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class
			 where T4 : class
			 where T5 : class
			 where T6 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class
			 where T4 : class
			 where T5 : class
			 where T6 : class
			 where T7 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8> receive)
			 where T1 : class
			 where T2 : class
			 where T3 : class
			 where T4 : class
			 where T5 : class
			 where T6 : class
			 where T7 : class
			 where T8 : class            
        {
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);        
            AddDependency(typeof(T11), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);        
            AddDependency(typeof(T11), dependency);        
            AddDependency(typeof(T12), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);        
            AddDependency(typeof(T11), dependency);        
            AddDependency(typeof(T12), dependency);        
            AddDependency(typeof(T13), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);        
            AddDependency(typeof(T11), dependency);        
            AddDependency(typeof(T12), dependency);        
            AddDependency(typeof(T13), dependency);        
            AddDependency(typeof(T14), dependency);
        }

        internal static void Inject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(IConsumer component, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> receive)
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
            if (_dependenciesByComponent.ContainsKey(component))
                return;

            var dependency = new Dependency<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(component, receive);
            _dependenciesByComponent[component] = dependency;
        
            AddDependency(typeof(T1), dependency);        
            AddDependency(typeof(T2), dependency);        
            AddDependency(typeof(T3), dependency);        
            AddDependency(typeof(T4), dependency);        
            AddDependency(typeof(T5), dependency);        
            AddDependency(typeof(T6), dependency);        
            AddDependency(typeof(T7), dependency);        
            AddDependency(typeof(T8), dependency);        
            AddDependency(typeof(T9), dependency);        
            AddDependency(typeof(T10), dependency);        
            AddDependency(typeof(T11), dependency);        
            AddDependency(typeof(T12), dependency);        
            AddDependency(typeof(T13), dependency);        
            AddDependency(typeof(T14), dependency);        
            AddDependency(typeof(T15), dependency);
        }

        #endregion
    }
}