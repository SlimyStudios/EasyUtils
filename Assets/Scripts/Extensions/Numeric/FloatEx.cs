using System;

public static class FloatEx
{
        /// <summary>
       /// Returns float sign.
       /// </summary>
        public static int Sign(this float number) 
            => Math.Sign(number);
        
        /// <summary>
        /// True if float is even.
        /// </summary>
        /// <returns></returns>
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
