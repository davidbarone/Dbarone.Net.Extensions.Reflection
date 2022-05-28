namespace Dbarone.Net.Extensions.Reflection;
using System.Reflection;

/// <summary>
/// A collection of .NET reflection extension methods.
/// </summary>
public static class ReflectionExtensions
{
    /// <summary>
    /// Returns a collection of properties on an object decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="obj">The object instance to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the properties defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of properties containing the specified attribute.</returns>
    public static IEnumerable<PropertyInfo> GetPropertiesDecoratedBy<T>(this object obj, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return obj.GetType()
            .GetProperties(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Returns a collection of properties for a given type decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="t">The type to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the properties defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of properties containing the specified attribute.</returns>
    public static IEnumerable<PropertyInfo> GetPropertiesDecoratedBy<T>(this Type t, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return t
            .GetProperties(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Returns a collection of members on an object decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="obj">The object instance to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the members defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of members containing the specified attribute.</returns>
    public static IEnumerable<MemberInfo> GetMembersDecoratedBy<T>(this object obj, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return obj.GetType()
            .GetMembers(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Returns a collection of members for a given type decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="t">The type to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the members defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of members containing the specified attribute.</returns>
    public static IEnumerable<MemberInfo> GetMembersDecoratedBy<T>(this Type t, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return t
            .GetMembers(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Returns a collection of methods on an object decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="obj">The object instance to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the methods defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of methods containing the specified attribute.</returns>
    public static IEnumerable<MethodInfo> GetMethodsDecoratedBy<T>(this object obj, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return obj.GetType()
            .GetMethods(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Returns a collection of methods for a given type decorated by the specified attribute type.
    /// </summary>
    /// <typeparam name="T">The specified attribute type.</typeparam>
    /// <param name="t">The object type to check.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of element for custom attributes.</param>
    /// <param name="bindingFlags">When overridden in a derived class, searches for the methods defined for the current System.Type , using the specified binding constraints.</param>
    /// <returns>A list of methods containing the specified attribute.</returns>
    public static IEnumerable<MethodInfo> GetMethodsDecoratedBy<T>(this Type t, bool inherit = false, BindingFlags bindingFlags = BindingFlags.Default) where T : Attribute
    {
        return t
            .GetMethods(bindingFlags)
            .Where(pi => Attribute.IsDefined(pi, typeof(T), inherit));
    }

    /// <summary>
    /// Gets the value of a object's property using reflection.
    /// </summary>
    /// <param name="obj">The object to get the value from.</param>
    /// <param name="propertyName">The name of the property</param>
    /// <returns>The property value.</returns>
    public static object? Value(this object obj, string propertyName)
    {
        Type t = obj.GetType();
        var pi = t.GetProperty(propertyName);
        if (pi != null)
        {
            return pi.GetValue(obj, null);
        }
        else
        {
            throw new Exception($"object.Value(): Invalid property name.");
        }
    }

    /// <summary>
    /// Returns a collection of types in an app domain that a specified base type is assignable from.
    /// </summary>
    /// <param name="domain">The AppDomain to search for types.</param>
    /// <param name="baseType">The base type.</param>
    /// <returns>Returns a collection of types that the base type is assignable from.</returns>
    public static IEnumerable<Type> GetTypesAssignableFrom(this AppDomain domain, Type baseType)
    {
        List<Type> types = new List<Type>();
        // Get all the command types:
        foreach (var assembly in domain.GetAssemblies())
        {
            try
            {
                foreach (var type in assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t)))
                {
                    // Remove word 'command' from class name if present
                    if (!types.Contains(type))
                        types.Add(type);
                }
            }
            catch (ReflectionTypeLoadException)
            {
            }
        }
        return types;
    }
    
    /// <summary>
    /// Returns a collection of types in an AppDomain that are a subclass of a specified base type.
    /// </summary>
    /// <typeparam name="T">The base type.</typeparam>
    /// <param name="domain">The AppDomain to search for types.</param>
    /// <returns>Returns a collection of types that subclass the specified type.</returns>
    public static IEnumerable<Type> GetSubclassTypesOf<T>(this AppDomain domain)
    {
        List<Type> types = new List<Type>();

        // Get all the command types:
        foreach (var assembly in domain.GetAssemblies())
        {
            try
            {
                foreach (var type in assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T))))
                    types.Add(type);
            }
            catch (ReflectionTypeLoadException)
            {
            }
        }
        return types;
    }

    /// <summary>
    /// Returns true if a PropertyInfo object is an indexer property.
    /// </summary>
    /// <param name="prop">The property to check.</param>
    /// <returns>Returns true if the property is an indexer property.</returns>
    public static bool IsIndexerProperty(this PropertyInfo prop)
    {
        return prop.GetIndexParameters().Length > 0;
    }    
}
