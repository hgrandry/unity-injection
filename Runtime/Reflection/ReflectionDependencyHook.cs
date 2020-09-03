using UnityEngine;

namespace HGrandry.Injection
{
    public class ReflectionDependencyHook : MonoBehaviour
    {
        internal Dependency Dependency { get; set; }
        
        private void OnDestroy()
        {
            DependencySolver.RemoveDependency(Dependency);
        }
    }
}