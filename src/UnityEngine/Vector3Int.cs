namespace UnityEngine;

public struct Vector3Int
{
    public static Vector3Int operator +(Vector3Int a, Vector3Int b) => default;

    public static implicit operator Vector3(Vector3Int v) => default;
}
