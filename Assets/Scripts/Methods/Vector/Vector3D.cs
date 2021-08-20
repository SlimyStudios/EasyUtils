using UnityEngine;

namespace EasyUtils
{
    public static class Vector3D
    {
        /// <summary>
        ///   <para>Shorthand for writing Vector2(1, 1).</para>
        /// </summary>
        public static readonly Vector3 upR = new Vector3(1f, 1f);
        
        /// <summary>
        ///   <para>Shorthand for writing Vector2(1, -1).</para>
        /// </summary>
        public static readonly Vector3 upL = new Vector3(1f, -1f);
        
        /// <summary>
        ///   <para>Shorthand for writing Vector2(-1, 1).</para>
        /// </summary>
        public static readonly Vector3 downR = new Vector3(-1f, 1f);
        
        /// <summary>
        ///   <para>Shorthand for writing Vector2(-1, -1).</para>
        /// </summary>
        public static readonly Vector3 downL = new Vector3(-1f, -1f);
        
        /// <summary>
        /// Multiplies "left" by x, y, z and assigns result to "left" (left.x *= right.x)
        /// <para>Returns the result.</para>
        /// </summary>
        public static Vector3 Product(ref Vector3 left, in Vector3 right)
        {
            left.x *= right.x;
            left.y *= right.y;
            left.z *= right.z;

            return left;
        }

        /// <summary>
        /// Multiplies "left" components by "right" components (left.x * right.x) and returns the result.
        /// </summary>
        public static Vector3 Product(Vector3 left, in Vector3 right)
        {
            left.x *= right.x;
            left.y *= right.y;
            left.z *= right.z;

            return left;
        }
        
        /// <summary>
        /// Multiplies "left" by x, y, z and assigns result to "left" (left.x *= x)
        /// <para>Returns the result.</para>
        /// </summary>
        public static Vector3 Product(ref Vector3 left, float x, float y = 1, float z = 1)
        {
            left.x *= x;
            left.y *= y;
            left.z *= z;

            return left;
        }
        
        /// <summary>
        /// Multiplies "left" by x, y, z (left.x * x) and returns the result.
        /// </summary>
        public static Vector3 Product(Vector3 left, float x, float y = 1, float z = 1)
        {
            left.x *= x;
            left.y *= y;
            left.z *= z;

            return left;
        }
    }
}