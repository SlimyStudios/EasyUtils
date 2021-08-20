using UnityEngine;

namespace EasyUtils
{
    public static class ComponentEx
    {
        public static void GetSelfComponent<T>(this Component comp, out T component)
        {
            component = comp.GetComponent<T>();
        }

        public static void GetChildComponent<T>(this Component comp, out T component)
        {
            component = comp.GetComponentInChildren<T>();
        }
        
        /// <summary>
        /// Finds a component on self, if not found, on children.
        /// </summary>
        /// <returns> Returns true if found.</returns>
        public static bool GetAnyComponent<T>(this Component comp, out T component)
        {
            var found = comp.TryGetComponent(out component);

            int childNum = comp.transform.childCount - 1;
            
            while (!found && childNum >= 0)
            {
                found = comp.transform.GetChild(childNum).TryGetComponent(out component);
                --childNum;
            }

            return found;
        }
    }
}