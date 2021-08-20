using System;
using UnityEngine;

namespace EasyUtils
{
    public static class TransformEx
    {
        public static void SetX(this Transform transform, float newX)
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(newX, pos.y, pos.z);
        }
    
        public static void SetY(this Transform transform, float newY)
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, newY, pos.z);
        }
    
        public static void SetZ(this Transform transform, float newZ)
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, pos.y, newZ);
        }

        public static void SetXY(this Transform transform, Vector3 vector)
        {
            float z = transform.position.z;
            transform.position = new Vector3(vector.x, vector.y, z);
        }
        
        public static void SetXY(this Transform transform, Vector2 vector)
        {
            transform.position = new Vector3(vector.x, vector.y, 0);
        }

        /// <summary>
        /// Sets position to newX, newY and newZ, works with any combination. <para>For example to set only Y = 1 and Z = 3 write SetPos(newY:1, newZ:3)</para>
        /// </summary>
        public static void SetPos(this Transform transform, float newX = Single.NaN, float newY = Single.NaN, float newZ = Single.NaN)
        {
            Vector3 pos = transform.position;

            if (float.IsNaN(newX)) newX = pos.x;
            if (float.IsNaN(newY)) newY = pos.y;
            if (float.IsNaN(newZ)) newZ = pos.z;

            transform.position = new Vector3(newX, newY, newZ);
        }

        public static void AddX(this Transform transform, float x)
        {
            Vector3 pos = transform.position;
            pos.x += x;
            transform.position = pos;
        }
    
        public static void AddY(this Transform transform, float y)
        {
            Vector3 pos = transform.position;
            pos.y += y;
            transform.position = pos;
        }
    
        public static void AddZ(this Transform transform, float z)
        {
            Vector3 pos = transform.position;
            pos.z += z;
            transform.position = pos;
        }

        /// <summary>
        /// Adds newX, newY and newZ to position, works with any combination.<para>For example, to add only Y += 1 and Z += 3 write AddPos(newY:1, newZ:3)</para>
        /// </summary>
        public static void AddPos(this Transform transform, float newX = 0, float newY = 0, float newZ = 0)
        {
            Vector3 pos = transform.position;
            pos.x += newX;
            pos.y += newY;
            pos.z += newZ;
            transform.position = pos;
        }
        
        public static void GetChildComponentRecursively<T>(this Transform parent, ref T component)
        {
            // Search component on all childs
            foreach (Transform child in parent)
            {
                // If found, return
                if (child.TryGetComponent(out component)) return;
                
                // If not, search in that child
                GetChildComponentRecursively(child, ref component);
            }
        }
    }
}