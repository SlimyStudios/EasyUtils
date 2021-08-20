using UnityEngine;

namespace EasyUtils
{
    public static class Vector2D
    {
        /// <summary>
        ///   <para>Shorthand for writing Vector2(1, 1).</para>
        /// </summary>
        public static readonly Vector2 upR = new Vector2(1f, 1f);

        /// <summary>
        ///   <para>Shorthand for writing Vector2(1, -1).</para>
        /// </summary>
        public static readonly Vector2 upL = new Vector2(1f, -1f);

        /// <summary>
        ///   <para>Shorthand for writing Vector2(-1, 1).</para>
        /// </summary>
        public static readonly Vector2 downR = new Vector2(-1f, 1f);

        /// <summary>
        ///   <para>Shorthand for writing Vector2(-1, -1).</para>
        /// </summary>
        public static readonly Vector2 downL = new Vector2(-1f, -1f);

        /// <summary>
        /// Multiplies "left" components by "right" components and assigns result to "left" (left.x *= right.x)
        /// <para>Returns the result.</para>
        /// </summary>
        public static Vector2 Product(ref Vector2 left, in Vector2 right)
        {
            left.x *= right.x;
            left.y *= right.y;

            return left;
        }

        /// <summary>
        /// Multiplies "left" components by "right" components (left.x * right.x) and returns the result.
        /// </summary>
        public static Vector2 Product(Vector2 left, in Vector2 right)
        {
            left.x *= right.x;
            left.y *= right.y;

            return left;
        }

        /// <summary>
        /// Multiplies "left" by x and y and assigns result to "left" (left.x *= x)
        /// <para>Returns the result.</para>
        /// </summary>
        public static Vector2 Product(ref Vector2 left, float x, float y = 1)
        {
            left.x *= x;
            left.y *= y;

            return left;
        }

        /// <summary>
        /// Multiplies "left" by x and y (left.x * x) and returns the result.
        /// </summary>
        public static Vector2 Product(Vector2 left, float x, float y = 1)
        {
            left.x *= x;
            left.y *= y;

            return left;
        }
    }
}