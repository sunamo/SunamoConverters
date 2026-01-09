// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts between C# type shortcuts (e.g., "string", "int") and their full System type names (e.g., "System.String", "System.Int32").
/// </summary>
public static class ConvertTypeShortcutFullName //: IConvertShortcutFullName
{
    const string SystemDot = "System.";

    /// <summary>
    /// Converts a C# type shortcut (e.g., "string", "int") to its full name (e.g., "System.String", "System.Int32").
    /// </summary>
    /// <param name="shortcut">The type shortcut.</param>
    /// <returns>The full type name.</returns>
    /// <exception cref="Exception">Thrown when the shortcut is not a supported keyword.</exception>
    public static string FromShortcut(string shortcut)
    {
        switch (shortcut)
        {
            case "string":
                return "System.String";
            case "int":
                return "System.Int32";
            case "bool":
                return "System.Boolean";
            case "float":
                return "System.Single";
            case "DateTime":
                return "System.DateTime";
            case "double":
                return "System.Double";
            case "decimal":
                return "System.Decimal";
            case "char":
                return "System.Char";
            case "byte":
                return "System.Byte";
            case "sbyte":
                return "System.SByte";
            case "short":
                return "System.Int16";
            case "long":
                return "System.Int64";
            case "ushort":
                return "System.UInt16";
            case "uint":
                return "System.UInt32";
            case "ulong":
                return "System.UInt64";
        }
        throw new Exception($"Unsupported keyword: '{shortcut}'");
    }
    /// <summary>
    /// Converts an object instance to its type shortcut.
    /// </summary>
    /// <param name="instance">The object instance.</param>
    /// <returns>The type shortcut.</returns>
    public static string ToShortcut(object instance)
    {
        return ToShortcut(instance.GetType().FullName!, false);
    }

    /// <summary>
    /// Converts a full type name to its C# shortcut.
    /// </summary>
    /// <param name="fullName">The full type name (e.g., "System.String").</param>
    /// <returns>The type shortcut (e.g., "string").</returns>
    public static string ToShortcut(string fullName)
    {
        return ToShortcut(fullName, true);
    }

    /// <summary>
    /// Converts a full type name to its C# shortcut.
    /// </summary>
    /// <param name="fullName">The full type name (e.g., "System.String" or "String").</param>
    /// <param name="isThrowingExceptionWhenNotBasicType">If true, throws an exception for non-basic types; otherwise returns the full name.</param>
    /// <returns>The type shortcut or the original full name.</returns>
    /// <exception cref="Exception">Thrown when the type is not a basic type and isThrowingExceptionWhenNotBasicType is true.</exception>
    public static string ToShortcut(string fullName, bool isThrowingExceptionWhenNotBasicType)
    {
        if (!fullName.StartsWith(SystemDot))
        {
            fullName = SystemDot + fullName;
        }
        switch (fullName)
        {
            case "System.String":
                return "string";
            case "System.Int32":
                return "int";
            case "System.Boolean":
                return "bool";
            case "System.Single":
                return "float";
            case "System.DateTime":
                return "DateTime";
            case "System.Double":
                return "double";
            case "System.Decimal":
                return "decimal";
            case "System.Char":
                return "char";
            case "System.Byte":
                return "byte";
            case "System.SByte":
                return "sbyte";
            case "System.Int16":
                return "short";
            case "System.Int64":
                return "long";
            case "System.UInt16":
                return "ushort";
            case "System.UInt32":
                return "uint";
            case "System.UInt64":
                return "ulong";
        }
        if (isThrowingExceptionWhenNotBasicType)
        {
            throw new Exception($"Unsupported type: '{fullName}'");
        }
        return fullName;
    }
}