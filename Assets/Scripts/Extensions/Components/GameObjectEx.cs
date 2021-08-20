using UnityEngine;

namespace EasyUtils
{
    public static class GameObjectEx
    {
        public static void GetSelfComponent<T>(this GameObject go, out T component)
        {
            component = go.GetComponent<T>();
        }
    
        public static void GetChildComponent<T>(this GameObject go, out T component)
        {
            component = go.GetComponentInChildren<T>();
        }
        
        /// <summary>
        /// Finds a component on self, if not found, on children.
        /// </summary>
        /// <returns> Returns true if found.</returns>
        public static bool GetAnyComponent<T>(this GameObject go, out T component)
        {
            var found = go.TryGetComponent(out component);

            int childNum = go.transform.childCount - 1;
            
            while (!found && childNum >= 0)
            {
                found = go.transform.GetChild(childNum).TryGetComponent(out component);
                --childNum;
            }

            return found;
        }
    }
}