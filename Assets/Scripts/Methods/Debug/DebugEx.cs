using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public static class DebugEx
{
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
    public static void LogVar<T>(Expression<Func<T>> variable)
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
    /// <param name="variables"> Variables to log.</param>
    public static void LogVars<T>(params Expression<Func<T>>[] variables)
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
    public static void LogList<T>(IEnumerable<T> list, string listName = "List")
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
    public static void LogCurrentMethod(string message = "Executed", [CallerMemberName] string name = "")
    {
        Debug.Log($"{name} {message}");
    }
}
