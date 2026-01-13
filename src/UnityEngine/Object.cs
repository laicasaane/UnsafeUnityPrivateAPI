using System;

namespace UnityEngine;

public class Object
{
    public static class MarshalledUnityObject
    {
        public static IntPtr Marshal<T>(T obj) where T : Object
        {
            return default;
        }

        public static IntPtr MarshalNotNull<T>(T obj) where T : Object
        {
            return default;
        }

        public static void TryThrowEditorNullExceptionObject(Object unityObj, string parameterName)
        {
        }
    }
}
