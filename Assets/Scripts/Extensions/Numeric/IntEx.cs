using System;

	/// <summary>
    /// Class for Int extensions
    /// </summary>
public static class IntEx
{
    /// <summary>
    /// Returns number sign.
    /// </summary>
    public static int Sign(this int number) => Math.Sign(number);
    
    /// <summary>
    /// True if number is even.
    /// </summary>
    /// <returns></returns>
    public static bool IsEven(this int number) => number % 2 == 0;
    
    /// <summary>
    /// True if int is equal to float based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 5 and 4.9f are equal.</para>
    /// </summary>
    public static bool IsEqual(this int number, float other, float tolerance)
        => Math.Abs(number - other) < tolerance;
    
    /// <summary>
    /// True if int is equal to float based on certain tolerance.
    /// <para> Example: If tolerance is 0.1, 5 and 4.9 are equal.</para>
    /// </summary>
    public static bool IsEqual(this int number, double other, float tolerance)
        => Math.Abs(number - other) < tolerance;
}
