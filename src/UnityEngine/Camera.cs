using System;

namespace UnityEngine;

public sealed class Camera : Behaviour
{
    public static extern float get_aspect_Injected(IntPtr _unity_self);

    public static extern void set_aspect_Injected(IntPtr _unity_self, float value);

    public static extern float get_orthographicSize_Injected(IntPtr _unity_self);

    public static extern void set_orthographicSize_Injected(IntPtr _unity_self, float value);

    public static extern bool get_orthographic_Injected(IntPtr _unity_self);

    public static extern void set_orthographic_Injected(IntPtr _unity_self, bool value);
}
