#pragma warning disable IDE1006 // Naming Styles

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

namespace PrivateAPIBridge;

using MarshalledUnityObject = UnityEngine.Object.MarshalledUnityObject;
using CellSwizzle = GridLayout.CellSwizzle;
using CellLayout = GridLayout.CellLayout;

/// <summary>
/// A struct providing unsafe access to <see cref="Grid"/>.
/// </summary>
public readonly struct UnsafeGridHandle
{
    private readonly IntPtr _ptr;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private UnsafeGridHandle(IntPtr ptr)
    {
        _ptr = ptr;
    }

    /// <summary>
    /// The size of each cell in the Grid.
    /// </summary>
    public Vector3 cellSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            Grid.get_cellSize_Injected(_ptr, out var ret);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Grid.set_cellSize_Injected(_ptr, ref value);
        }
    }

    /// <summary>
    /// The size of the gap between each cell in the Grid.
    /// </summary>
    public Vector3 cellGap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            Grid.get_cellGap_Injected(_ptr, out var ret);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Grid.set_cellGap_Injected(_ptr, ref value);
        }
    }

    /// <summary>
    /// The layout of the cells in the Grid.
    /// </summary>
    public CellLayout cellLayout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Grid.get_cellLayout_Injected(_ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Grid.set_cellLayout_Injected(_ptr, value);
        }
    }

    /// <summary>
    /// The cell swizzle for the Grid.
    /// </summary>
    public CellSwizzle cellSwizzle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Grid.get_cellSwizzle_Injected(_ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Grid.set_cellSwizzle_Injected(_ptr, value);
        }
    }

    /// <summary>
    /// Creates an <see cref="UnsafeGridHandle"/> from a <see cref="Grid"/>.
    /// </summary>
    /// <param name="grid">The grid to create the handle from.</param>
    /// <returns>A new <see cref="UnsafeGridHandle"/>.</returns>
    /// <exception cref="NullReferenceException">Thrown when the grid is null or invalid.</exception>
    public static UnsafeGridHandle CreateFrom([NotNull] Grid grid)
    {
        var ptr = MarshalledUnityObject.MarshalNotNull(grid);

        if (ptr == (IntPtr)0)
        {
            ThrowHelper.ThrowNullReferenceException(grid);
        }

        return new(ptr);
    }

    /// <summary>
    /// Returns the local bounds for a cell at the location.
    /// </summary>
    /// <param name="cellPosition">Location of the cell.</param>
    /// <returns>Local bounds of cell at the location.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Bounds GetBoundsLocal(Vector3Int cellPosition)
    {
        GridLayout.GetBoundsLocal_Injected(_ptr, ref cellPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Returns the local bounds for the groups of cells at the location.
    /// </summary>
    /// <param name="origin">Origin of the group of cells.</param>
    /// <param name="size">Size of the group of cells.</param>
    /// <returns>Local bounds of the group of cells at the location.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Bounds GetBoundsLocal(Vector3 origin, Vector3 size)
    {
        GridLayout.GetBoundsLocalOriginSize_Injected(_ptr, ref origin, ref size, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a cell position to local position space.
    /// </summary>
    /// <param name="cellPosition">Cell position to convert.</param>
    /// <returns>Local position of the cell position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 CellToLocal(Vector3Int cellPosition)
    {
        GridLayout.CellToLocal_Injected(_ptr, ref cellPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a local position to cell position.
    /// </summary>
    /// <param name="localPosition">Local Position to convert.</param>
    /// <returns>Cell position of the local position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3Int LocalToCell(Vector3 localPosition)
    {
        GridLayout.LocalToCell_Injected(_ptr, ref localPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts an interpolated cell position in floats to local position space.
    /// </summary>
    /// <param name="cellPosition">Interpolated cell position to convert.</param>
    /// <returns>Local position of the cell position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 CellToLocalInterpolated(Vector3 cellPosition)
    {
        GridLayout.CellToLocalInterpolated_Injected(_ptr, ref cellPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a local position to interpolated cell position.
    /// </summary>
    /// <param name="localPosition">Local Position to convert.</param>
    /// <returns>Interpolated cell position of the local position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 LocalToCellInterpolated(Vector3 localPosition)
    {
        GridLayout.LocalToCellInterpolated_Injected(_ptr, ref localPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a cell position to world position space.
    /// </summary>
    /// <param name="cellPosition">Cell position to convert.</param>
    /// <returns>World position of the cell position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 CellToWorld(Vector3Int cellPosition)
    {
        GridLayout.CellToWorld_Injected(_ptr, ref cellPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a world position to cell position.
    /// </summary>
    /// <param name="worldPosition">World Position to convert.</param>
    /// <returns>Cell position of the world position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3Int WorldToCell(Vector3 worldPosition)
    {
        GridLayout.WorldToCell_Injected(_ptr, ref worldPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a local position to world position.
    /// </summary>
    /// <param name="localPosition">Local Position to convert.</param>
    /// <returns>World position of the local position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 LocalToWorld(Vector3 localPosition)
    {
        GridLayout.LocalToWorld_Injected(_ptr, ref localPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Converts a world position to local position.
    /// </summary>
    /// <param name="worldPosition">World Position to convert.</param>
    /// <returns>Local position of the world position.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 WorldToLocal(Vector3 worldPosition)
    {
        GridLayout.WorldToLocal_Injected(_ptr, ref worldPosition, out var ret);
        return ret;
    }

    /// <summary>
    /// Get the default center coordinate of a cell for the set layout of the Grid.
    /// </summary>
    /// <returns>Cell Center coordinate.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 GetLayoutCellCenter()
    {
        GridLayout.GetLayoutCellCenter_Injected(_ptr, out var ret);
        return ret;
    }

    /// <summary>
    /// Get the logical center coordinate of a grid cell in local space.
    /// </summary>
    /// <param name="position">Grid cell position.</param>
    /// <returns>
    /// Center of the cell transformed into local space coordinates.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 GetCellCenterLocal(Vector3Int position)
    {
        return CellToLocalInterpolated(position + GetLayoutCellCenter());
    }

    /// <summary>
    /// Get the logical center coordinate of a grid cell in world space.
    /// </summary>
    /// <param name="position">Grid cell position.</param>
    /// <returns>
    /// Center of the cell transformed into world space coordinates.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Vector3 GetCellCenterWorld(Vector3Int position)
    {
        return LocalToWorld(CellToLocalInterpolated(position + GetLayoutCellCenter()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Swizzle(CellSwizzle swizzle, Vector3 position)
    {
        Grid.Swizzle_Injected(swizzle, ref position, out var ret);
        return ret;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position)
    {
        Grid.InverseSwizzle_Injected(swizzle, ref position, out var ret);
        return ret;
    }
}
