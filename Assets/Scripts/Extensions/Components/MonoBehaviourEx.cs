using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EasyUtils
{
    [DefaultExecutionOrder(-10)]
    public class MonoBehaviourEx : MonoBehaviour
    {
        // 3D
        protected Collider _collider;
        protected Rigidbody _rigidbody;
        
        // 2D
        protected Collider2D _collider2D;
        protected Rigidbody2D _rigidbody2D;
        
        // Common
        protected SpriteRenderer _spriteRenderer;
        protected Transform _transform;

        protected Scene GetActiveScene;
        protected int GetActiveSceneIndex;
        protected string GetActiveSceneName;
        
        protected virtual void Awake()
        {
            // 3D
            TryGetComponent(out _collider);
            TryGetComponent(out _rigidbody);
            
            // 2D
            TryGetComponent(out _collider2D);
            TryGetComponent(out _rigidbody2D);
            
            // Common
            TryGetComponent(out _spriteRenderer);
            
            GetActiveScene = SceneManager.GetActiveScene();
            GetActiveSceneIndex = GetActiveScene.buildIndex;
            GetActiveSceneName = GetActiveScene.name;
        }
        
        /// <summary>
        /// Finds a component on self, if not found, on children.
        /// </summary>
        /// <returns> Returns true if found.</returns>
        protected bool GetAnyComponent<T>(out T component)
        {
            var found = TryGetComponent(out component);

            int childNum = transform.childCount - 1;
            
            while (!found && childNum >= 0)
            {
                found = transform.GetChild(childNum).TryGetComponent(out component);
                --childNum;
            }

            return found;
        }

        /// <summary>
        /// Same as <c>T component = GetComponent&lt;T&gt;();</c>
        /// <para> </para>
        /// <para> Usage: <c>GetSelfComponent(out component);</c></para>
        /// </summary>
        protected void GetSelfComponent<T>(out T component)
        {
            component = GetComponent<T>();
        }
        
        /// <summary>
        /// Same as <c>T component = GetComponentInChildren&lt;T&gt;();</c>
        /// <para> </para>
        /// <para> Usage: <c>GetChildComponent(out component);</c></para>
        /// </summary>
        protected void GetChildComponent<T>(out T component)
        {
            component = GetComponentInChildren<T>();
        }
        
        /// <summary>
        /// Same as <c>T component = GetComponentInChildren&lt;T&gt;(); but only for children with name "childName"</c>
        /// <para> </para>
        /// <para> Usage: <c>GetChildComponentByName(out component, childName);</c></para>
        /// </summary>
        protected void GetChildComponentByName<T>(out T component, string childName)
        {
            bool found = false;
            component = default;
            
            foreach (Transform child in transform)
            {
                if (child.name == childName)
                {
                    if (child.TryGetComponent(out T comp))
                    {
                        component = comp;
                        return;
                    }
                    
                    found = true;
                }
            }
            
            if (found) Debug.Log($"The child with name {childName} doesn't have a component of type {typeof(T).Name}.");
            else Debug.Log($"This Game Object doesn't have a child with name {childName}.");
        }
        
        /// <summary>
        /// Logs variable with its name.
        /// <para> </para>
        /// <para> Usage </para>
        /// <para> LogVar( ()=> variable ); </para>
        /// <para> </para>
        /// <para> Output</para>
        /// <para> Name: value </para>
        /// </summary>
        /// <param name="variable"> Variable to log.</param>
        protected void LogVar<T>(Expression<Func<T>> variable)
        {
            var body = (MemberExpression) variable.Body;
            Debug.Log(body.Member.Name + ": " + ((FieldInfo)body.Member).GetValue(((ConstantExpression)body.Expression).Value));
        }
            
        /// <summary>
        /// Logs variables with their name. All variables have to be of the same type.
        /// <para> </para>
        /// <para> Usage</para>
        /// <para> LogVars( ()=> var1, ()=> var2, ...); </para>
        /// <para> </para>
        /// <para> Output</para>
        /// <para> Name1: value1 </para>
        /// <para> Name2: value2 </para>
        /// </summary>
        /// <param name="variables"></param>
        /// <typeparam name="T"></typeparam>
        protected void LogVars<T>(params Expression<Func<T>>[] variables)
        {
            foreach (var variable in variables)
            {
                var body = (MemberExpression) variable.Body;
                Debug.Log(body.Member.Name + ": " + ((FieldInfo)body.Member).GetValue(((ConstantExpression)body.Expression).Value));
            }
        }
        
        /// <summary>
        /// Logs all the elements in the list / array.
        /// <para> You can specify the list name, or it will use the default "List".</para>
        /// </summary>
        protected void LogList<T>(IEnumerable<T> list, string listName = "List")
        {
            int i = 0;
            foreach (var elem in list)
            {
                Debug.Log($"{listName}[{i++}]: {elem}");
            }
        }

        /// <summary>
        /// Logs current method name, useful when you want to know if a method executed correctly.
        /// <para> Usage: <c>LogCurrentMethod("Message" (optional) ); </c></para>
        /// <para> </para>
        /// <para> Output: MethodName Message</para>
        /// </summary>
        /// <param name="message"> Message to display with the name of the method, "Executed" by default.</param>
        /// <param name="name"> Name to display, it's the method name by default.</param>
        protected static void LogCurrentMethod(string message = "Executed", [CallerMemberName] string name = "")
        {
            Debug.Log($"{name} {message}");
        }
    }
}