using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Vector2Ex
{
    public static Vector3Int v3int;
    public static Vector2Int v2int;
    public static Vector3 v3;
    public static Vector2 v2;
    
    #region Operators
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2 FastMultiply(this Vector2 v, float f)
    {
        v.x *= f;
        v.y *= f;
        return v;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2 FastMultiply(this Vector2 v, Vector2 v2)
    {
        v.x *= v2.x;
        v.y *= v2.y;
        return v;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2 FastAdd(this Vector2 v, Vector2 v2)
    {
        v.x += v2.x;
        v.y += v2.y;
        return v;
    }   
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2 FastSubstract(this Vector2 v, Vector2 v2)
    {
        v.x -= v2.x;
        v.y -= v2.y;
        return v;
    }
    #endregion

    #region Conversors

    /// <summary>
    /// Returns screen point as world coordinates.
    /// </summary>
    public static Vector3 ScreenToWorld(this Vector2 screenPoint) 
        => EasyExtensions.cam.ScreenToWorldPoint(screenPoint);

    /// <summary>
    /// Returns the vector as a Vector3Int. Uses basic float to int cast.
    /// </summary>
    public static Vector3Int ToVector3Int(this Vector2 v)
    {
        v3int.x = (int)v.x;
        v3int.y = (int)v.y;
        v3int.z = 0;
        return v3int;
    }
    
    /// <summary>
    /// Returns the vector as a Vector2Int. Uses basic float to int cast.
    /// </summary>
    public static Vector2Int ToVector2Int(this Vector2 v)
    {
        v2int.x = (int)v.x;
        v2int.y = (int)v.y;
        return v2int;
    }

    #endregion

    #region Math

    public static Vector2 Round(this Vector2 v) => v.SetXY(v.x.Round(), v.y.Round());
    
    public static Vector2 Raw(this Vector2 v) => v.SetXY(v.x.SignF(), v.y.SignF());

    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2 FastNormalized(this Vector2 v)
    {
        double m = Math.Sqrt(v.x * v.x + v.y * v.y);
        if (m > 9.99999974737875E-06)
        {
            float fm = (float)m;
            v.x /= fm;
            v.y /= fm;
            return v;
        }
            
        return Vector2.zero;
    }
    
    #endregion

    #region Setters

    public static Vector2 SetX(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }
    
    public static Vector2 SetY(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }
    
    public static Vector2 SetXY(this Vector2 v, float x, float y)
    {
        v.x = x;
        v.y = y;
        return v;
    }

    #endregion
}
