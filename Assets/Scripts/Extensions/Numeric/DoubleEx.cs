using System;

public static class DoubleEx
{
    /// <summary>
    /// Returns number sign.
    /// </summary>
    public static int Sign(this double number) => Math.Sign(number);

    /// <summary>
    /// True if number is even.
    /// </summary>
    /// <returns></returns>
    public static bool IsEven(this double number) => number % 2 == 0;
    
    /// <summary>
    /// True if double is equal to other based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9 and 5.0 are equal.</para>
    /// </summary>
    public static bool IsEqual(this double number, double other, float tolerance)
        => Math.Abs(number - other) < tolerance;
    
    /// <summary>
    /// True if double is equal to float based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9 and 5f are equal.</para>
    /// </summary>
    public static bool IsEqual(this double number, float other, float tolerance)
        => Math.Abs(number - other) < tolerance;

    /// <summary>
    /// True if double is equal to int based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 4.9 and 5 are equal.</para>
    /// </summary>
    public static bool IsEqual(this double number, int other, float tolerance) 
        => Math.Abs(number - other) < tolerance;
}
