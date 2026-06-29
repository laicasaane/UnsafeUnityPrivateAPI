#pragma warning disable IDE1006 // Naming Styles

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnsafeUnityEnginePrivateAPI;

using MarshalledUnityObject = UnityEngine.Object.MarshalledUnityObject;

/// <summary>
/// A struct providing unsafe access to <see cref="Camera"/>.
/// </summary>
public readonly struct UnsafeCameraHandle
{
    private readonly IntPtr _ptr;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private UnsafeCameraHandle(IntPtr ptr)
    {
        _ptr = ptr;
    }

    /// <summary>
    /// An invalid camera handle.
    /// </summary>
    public static UnsafeCameraHandle None => default;

    /// <summary>
    /// The aspect ratio (width divided by height).
    /// </summary>
    public float aspect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Camera.get_aspect_Injected(_ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Camera.set_aspect_Injected(_ptr, value);
        }
    }

    /// <summary>
    /// Camera's half-size when in orthographic mode.
    /// </summary>
    public float orthographicSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Camera.get_orthographicSize_Injected(_ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Camera.set_orthographicSize_Injected(_ptr, value);
        }
    }

    /// <summary>
    /// Is the camera orthographic (true) or perspective (false)?
    /// </summary>
    public bool orthographic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Camera.get_orthographic_Injected(_ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Camera.set_orthographic_Injected(_ptr, value);
        }
    }

    /// <summary>
    /// Creates an <see cref="UnsafeCameraHandle"/> from a <see cref="Camera"/>.
    /// </summary>
    /// <param name="camera">The camera to create the handle from.</param>
    /// <returns>A new <see cref="UnsafeCameraHandle"/>.</returns>
    /// <exception cref="NullReferenceException">Thrown when the camera is null or invalid.</exception>
    public static UnsafeCameraHandle CreateFrom([NotNull] Camera camera)
    {
        var ptr = MarshalledUnityObject.MarshalNotNull(camera);

        if (ptr == (IntPtr)0)
        {
            ThrowHelper.ThrowNullReferenceException(camera);
        }

        return new(ptr);
    }
}
