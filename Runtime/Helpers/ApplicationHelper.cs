using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace HGrandry.Injection
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    internal static class ApplicationHelper
    {
        private static bool _isPlaying;

        // Editor only
        public static bool IsStopping { get; private set; }
        public static bool IsStarting { get; private set; }

#if UNITY_EDITOR
        static ApplicationHelper()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange playModeStateChange)
        {
            // the application is stopping if the playMode changed as Application.isPlaying is still true)
            var wasPlaying = _isPlaying;
            _isPlaying = Application.isPlaying;
            IsStopping = wasPlaying && _isPlaying; // this is true just before the engine stops in the editor.
            IsStarting = !wasPlaying && _isPlaying;
        }
#endif
    }
}