# Dbarone.Net.Extensions.Reflection


>## T:Dbarone.Net.Extensions.Reflection.ReflectionExtensions

 A collection of .NET reflection extension methods. 

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetPropertiesDecoratedBy``1(System.Object,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of properties on an object decorated by the specified attribute type. 
| Name          | Description                                                                                                                                    |
| ------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| obj:          | The object instance to check.                                                                                                                  |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                              |
| bindingFlags: | When overridden in a derived class, searches for the properties defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetPropertiesDecoratedBy``1(System.Type,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of properties for a given type decorated by the specified attribute type. 
| Name          | Description                                                                                                                                    |
| ------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| t:            | The type to check.                                                                                                                             |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                              |
| bindingFlags: | When overridden in a derived class, searches for the properties defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetMembersDecoratedBy``1(System.Object,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of members on an object decorated by the specified attribute type. 
| Name          | Description                                                                                                                                 |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| obj:          | The object instance to check.                                                                                                               |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                           |
| bindingFlags: | When overridden in a derived class, searches for the members defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetMembersDecoratedBy``1(System.Type,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of members for a given type decorated by the specified attribute type. 
| Name          | Description                                                                                                                                 |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| t:            | The type to check.                                                                                                                          |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                           |
| bindingFlags: | When overridden in a derived class, searches for the members defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetMethodsDecoratedBy``1(System.Object,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of methods on an object decorated by the specified attribute type. 
| Name          | Description                                                                                                                                 |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| obj:          | The object instance to check.                                                                                                               |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                           |
| bindingFlags: | When overridden in a derived class, searches for the methods defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetMethodsDecoratedBy``1(System.Type,System.Boolean,System.Reflection.BindingFlags)
 Returns a collection of methods for a given type decorated by the specified attribute type. 
| Name          | Description                                                                                                                                 |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| t:            | The object type to check.                                                                                                                   |
| inherit:      | If true, specifies to also search the ancestors of element for custom attributes.                                                           |
| bindingFlags: | When overridden in a derived class, searches for the methods defined for the current System.Type , using the specified binding constraints. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.Value(System.Object,System.String)
 Gets the value of a object's property using reflection. 
| Name          | Description                       |
| ------------- | --------------------------------- |
| obj:          | The object to get the value from. |
| propertyName: | The name of the property          |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetTypesAssignableFrom(System.AppDomain,System.Type)
 Returns a collection of types in an app domain that a specified base type is assignable from. 
| Name      | Description                        |
| --------- | ---------------------------------- |
| domain:   | The AppDomain to search for types. |
| baseType: | The base type.                     |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetSubclassTypesOf``1(System.AppDomain)
 Returns a collection of types in an AppDomain that are a subclass of a specified base type. 
| Name    | Description                        |
| ------- | ---------------------------------- |
| domain: | The AppDomain to search for types. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.IsIndexerProperty(System.Reflection.PropertyInfo)
 Returns true if a PropertyInfo object is an indexer property. 
| Name  | Description            |
| ----- | ---------------------- |
| prop: | The property to check. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.IsNumeric(System.Type)
 Returns true if the .NET type is a numeric type. 
| Name  | Description        |
| ----- | ------------------ |
| type: | The type to check. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.Default(System.Type)
 Returns the default value for a type. For value types, returns default value. For reference types, returns null. 
| Name  | Description |
| ----- | ----------- |
| type: | The type.   |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetNullableType(System.Type)
 Gets the nullable type from a non-nullable type. 
| Name  | Description                                                                                                |
| ----- | ---------------------------------------------------------------------------------------------------------- |
| type: | The non-nullable type. Can be value or reference type. Reference types are assumed to be nullable already. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.GetNullableUnderlyingType(System.Type)
 Gets the underlying type for a nullable type. 
| Name  | Description        |
| ----- | ------------------ |
| type: | The nullable type. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.IsNullable(System.Type)
 Returns whether a type is a nullable type. 
| Name | Description |
| ---- | ----------- |
| t:   |             |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.Parse(System.Type,System.String)
 Parses a string to another type. The type must support the Parse method. 
| Name  | Description                                 |
| ----- | ------------------------------------------- |
| str:  | The string value to parse.                  |
| type: | The type of value to parse the string into. |

---
### M:Dbarone.Net.Extensions.Reflection.ReflectionExtensions.ParseNullable(System.Type,System.String)
 Parses a string to another type. The type must support the Parse method. Null or empty strings are 
| Name         | Description |
| ------------ | ----------- |
| expression:  |             |
| parseMethod: |             |

---
