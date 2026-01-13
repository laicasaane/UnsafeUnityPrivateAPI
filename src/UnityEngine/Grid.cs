using System;
using System.Runtime.InteropServices;

namespace UnityEngine;

using CellLayout = GridLayout.CellLayout;
using CellSwizzle = GridLayout.CellSwizzle;

public class Grid : Object
{
    public static extern void get_cellSize_Injected(IntPtr _unity_self, out Vector3 ret);

    public static extern void set_cellSize_Injected(IntPtr _unity_self, [In] ref Vector3 value);

    public static extern void get_cellGap_Injected(IntPtr _unity_self, out Vector3 ret);

    public static extern void set_cellGap_Injected(IntPtr _unity_self, [In] ref Vector3 value);

    public static extern CellLayout get_cellLayout_Injected(IntPtr _unity_self);

    public static extern void set_cellLayout_Injected(IntPtr _unity_self, CellLayout value);

    public static extern CellSwizzle get_cellSwizzle_Injected(IntPtr _unity_self);

    public static extern void set_cellSwizzle_Injected(IntPtr _unity_self, CellSwizzle value);

    public static extern void Swizzle_Injected(CellSwizzle swizzle, [In] ref Vector3 position, out Vector3 ret);

    public static extern void InverseSwizzle_Injected(CellSwizzle swizzle, [In] ref Vector3 position, out Vector3 ret);
}
