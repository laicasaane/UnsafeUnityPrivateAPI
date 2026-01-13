using System;
using System.Runtime.InteropServices;

namespace UnityEngine;

public partial class GridLayout : Object
{
    public enum CellLayout { }

    public enum CellSwizzle { }

    public static extern void get_cellSize_Injected(IntPtr _unity_self, out Vector3 ret);

    public static extern void get_cellGap_Injected(IntPtr _unity_self, out Vector3 ret);

    public static extern CellLayout get_cellLayout_Injected(IntPtr _unity_self);

    public static extern CellSwizzle get_cellSwizzle_Injected(IntPtr _unity_self);

    public static extern void GetBoundsLocal_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Bounds ret);

    public static extern void GetBoundsLocalOriginSize_Injected(IntPtr _unity_self, [In] ref Vector3 origin, [In] ref Vector3 size, out Bounds ret);

    public static extern void CellToLocal_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Vector3 ret);

    public static extern void LocalToCell_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3Int ret);

    public static extern void CellToLocalInterpolated_Injected(IntPtr _unity_self, [In] ref Vector3 cellPosition, out Vector3 ret);

    public static extern void LocalToCellInterpolated_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3 ret);

    public static extern void CellToWorld_Injected(IntPtr _unity_self, [In] ref Vector3Int cellPosition, out Vector3 ret);

    public static extern void WorldToCell_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition, out Vector3Int ret);

    public static extern void LocalToWorld_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, out Vector3 ret);

    public static extern void WorldToLocal_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition, out Vector3 ret);

    public static extern void GetLayoutCellCenter_Injected(IntPtr _unity_self, out Vector3 ret);
}
