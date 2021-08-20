using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class FloatEx
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Round(this float f) 
        => f >= 0 ? (int)(f+0.5f) : -(int)(0.5f-f);
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int RoundToInt(this float f) 
        => f >= 0 ? (int)(f+0.5f) : -(int)(0.5f-f);
    
    /// <summary>
    /// Returns sign of float.
    /// </summary>
    /// <returns> 1 if value &#62; 0. -1 if value &#60; 0. 0 if value == 0. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float SignF(this float f) 
        => Math.Sign(f);
    
    /// <summary>
    /// Returns sign of float.
    /// </summary>
    /// <returns> 1 if value &#62; 0. -1 if value &#60; 0. 0 if value == 0. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this float f) 
        => Math.Sign(f);
    
    /// <summary>
    /// Returns sign of float.
    /// </summary>
    /// <returns> 1 if value &#62;= 0. -1 if value &#60; 0. </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float MathfSign(this float f) 
        => Mathf.Sign(f);

    /// <summary>
    /// True if float is even.
    /// </summary>
    public static bool IsEven(this float number) 
        => number % 2 == 0;
        
    /// <summary>
    /// True if float is equal to other based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9f and 5f are equal.</para>
    /// </summary>
    public static bool IsEqual(this float number, float other, float tolerance) 
        => Math.Abs(number - other) < tolerance;

    /// <summary>
    /// True if float is equal to double based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9f and 5.0 are equal.</para>
    /// </summary>
    public static bool IsEqual(this float number, double other, float tolerance)
        => Math.Abs(number - other) < tolerance;
        
    /// <summary>
    /// True if float is equal to int based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9f and 5 are equal.</para>
    /// </summary>
    public static bool IsEqual(this float number, int other, float tolerance) 
        => Math.Abs(number - other) < tolerance;
}