Android doesn't know the string names, only the numeric id. To map from string to the id, reflection can be used.

```
Map<String,Integer> stringIds = new Map<String, Integer>();
FieldInfo[] fields = Resource.String.GetType().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
foreach (FieldInfo field in fields) {
    if (!field.IsInitOnly && field.IsLiteral) {
        stringIdsMap.add (field, field.GetValue(null));
    }
}
```

Alternatively the android getValue method can be used (which relies on Android's get identifier). 

```
public void getValue (String name, TypedValue outValue, boolean resolveRefs)
http://developer.android.com/reference/android/content/res/Resources.html#getValue(java.lang.String, android.util.TypedValue, boolean)
```


todo:
better approach
code generation based on resource file



Catalog.GetText -> manually specifying a string is error prone. generates run time errors.
better approach is to have compile time check that the resource is valid.

custom twine formatter is used to generate a static constant class.

public partial class String
    {
      
      public const string app_name = "value";

      }
    }

this works on both ios & android. the native resources are still generated for appium.