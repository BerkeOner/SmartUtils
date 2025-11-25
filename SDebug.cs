// Using SDebug.Log instead of Debug.Log will exclude your logs from build so it can run faster.
// Be aware logs still can be useful in builds since they are used to fix bug reports by players.
// Main advantage of SDebug is excluding unnecessary logs from build to save performance.

using UnityEngine;

namespace SmartUtils
{
    public static class SDebug // (Smart Debug)
    {
        /// <summary>
        /// Same as Debug.Log but this log will not be included in build.
        /// </summary>
        /// <param name="log"></param>
        public static void Log(string log = "")
        {
#if UNITY_EDITOR
            Debug.Log(log);
#endif
        }

        /// <summary>
        /// Same as Debug.LogWarning but this log will not be included in build.
        /// </summary>
        /// <param name="log"></param>
        public static void LogWarning(string log = "")
        {
#if UNITY_EDITOR
            Debug.LogWarning(log);
#endif
        }

        /// <summary>
        /// Same as Debug.LogError but this log will not be included in build.
        /// </summary>
        /// <param name="log"></param>
        public static void LogError(string log = "")
        {
#if UNITY_EDITOR
            Debug.LogError(log);
#endif
        }
    }
}

