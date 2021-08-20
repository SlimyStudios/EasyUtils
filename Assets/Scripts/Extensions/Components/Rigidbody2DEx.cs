using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyUtils
{
    public static class Rigidbody2DEx
    {
        /// <summary>
        /// Adds force in the X axis of the rigidbody (Vector2.right * force)
        /// </summary>
        public static void AddForceX(this Rigidbody2D rb, float force, ForceMode2D mode = ForceMode2D.Force)
        {
            rb.AddForce(Vector2.right * force, mode);
        }
    
        /// <summary>
        /// Adds force in the Y axis of the rigidbody (Vector2.up * force)
        /// </summary>
        public static void AddForceY(this Rigidbody2D rb, float force, ForceMode2D mode = ForceMode2D.Force)
        {
            rb.AddForce(Vector2.up * force, mode);
        }
    
        /// <summary>
        /// Adds force in the X and Y normalized axis of the rigidbody (Vector2.right * force + Vector2.up * force)
        /// </summary>
        public static void AddForceDiagonal(this Rigidbody2D rb, float force, ForceMode2D mode = ForceMode2D.Force)
        {
            Vector2 upR = (Vector2.up + Vector2.right).normalized;
            rb.AddForce(upR * force, mode);
        }

        /// <summary>
        /// Adds force in the X and Y normalized axis of the rigidbody (Vector2.right * force + Vector2.up * force)
        /// </summary>
        public static void AddForceDiagonal(this Rigidbody2D rb, float forceX, float forceY, ForceMode2D mode = ForceMode2D.Force)
        {
            Vector2 upR = (Vector2.up + Vector2.right).normalized;
            upR.x *= forceX;
            upR.y *= forceY;
            rb.AddForce(upR, mode);
        }
    }
}