using UnityEngine;

public static class Vector2Ex
{
    /// <summary>
    /// Returns screen point as world coordinates.
    /// </summary>
    public static Vector3 ScreenToWorld(this Vector2 screenPoint) 
    { 
        return EasyExtensions.cam.ScreenToWorldPoint(screenPoint);
    }
    
    /// <summary>
    /// Returns the vector as a Vector3Int. Uses basic float to int cast.
    /// </summary>
    public static Vector3Int ToVector3Int(this Vector2 vector)
    {
        Vector3Int intExVec = new Vector3Int
        {
            x = (int) vector.x, 
            y = (int) vector.y, 
            z = 0
        };

        return intExVec;
    }
    
    /// <summary>
    /// Returns the vector as a Vector2Int. Uses basic float to int cast.
    /// </summary>
    public static Vector2Int ToVector2Int(this Vector2 vector)
    {
        Vector2Int intVec = new Vector2Int
        {
            x = (int) vector.x, 
            y = (int) vector.y,
        };

        return intVec;
    }
}
