using UnityEngine;

public static class Vector3IntEx
{
    /// <summary>
    /// Returns the vector as a Vector3. Uses basic int to float cast.
    /// </summary>
    public static Vector3 ToVector3(this Vector3Int vector)
    {
        Vector3 vec3 = new Vector3
        {
            x = vector.x, 
            y = vector.y, 
            z = vector.z
        };

        return vec3;
    }
    
    /// <summary>
    /// Returns the vector as a Vector2. Uses basic int to float cast.
    /// </summary>
    public static Vector2 ToVector2(this Vector3Int vector)
    {
        Vector2 vec2 = new Vector2
        {
            x = vector.x, 
            y = vector.y,
        };

        return vec2;
    }

    /// <summary>
    /// Returns true if all values of vector a are less or equal than b.
    /// </summary>
    public static bool LessEqualThan(this Vector3Int a, Vector3Int b)
    {
        return a.x <= b.x && a.y <= b.y && a.z <= b.z;
    }
    
    /// <summary>
    /// Returns true if XY values of vector are less or equal than b.
    /// </summary>
    public static bool LessXYThan(this Vector3Int a, Vector3Int b)
    {
        return a.x <= b.x && a.y <= b.y;
    }  
    
    /// <summary>
    /// Returns true if XY values of vector are less or equal than b.
    /// </summary>
    public static bool LessThan(this Vector3Int a, Vector2Int b)
    {
        return a.x <= b.x && a.y <= b.y;
    }
}
