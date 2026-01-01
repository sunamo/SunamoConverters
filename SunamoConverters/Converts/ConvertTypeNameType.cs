namespace SunamoConverters.Converts;

/// <summary>
/// Converts between type name strings and System.Type objects for all supported basic types.
/// </summary>
public class ConvertTypeNameType
{
    /// <summary>
    /// Converts a type name string to a System.Type.
    /// Throws an exception if the type is not supported.
    /// If comparing the obtained type, use typeof(int, string, byte) not typeof(Int32, String, Byte).
    /// The input string must be without "System." prefix.
    /// </summary>
    /// <param name="typeName">The type name to convert (e.g., "string", "int", "Int32").</param>
    /// <returns>The corresponding System.Type.</returns>
    /// <exception cref="Exception">Thrown when the type name is not supported.</exception>
    public static Type ToType(string typeName)
    {
        switch (typeName)
        {
            case "string":
                return typeof(string);
            case "String":
                return typeof(string);
            case "int":
                return typeof(int);
            case "Int32":
                return typeof(int);
            case "bool":
                return typeof(bool);
            case "boolean":
                return typeof(bool);
            case "float":
                return typeof(float);
            case "Single":
                return typeof(float);
            case "DateTime":
                return typeof(DateTime);
            case "double":
                return typeof(double);
            case "Double":
                return typeof(double);
            case "decimal":
                return typeof(decimal);
            case "Decimal":
                return typeof(decimal);
            case "char":
                return typeof(char);
            case "Char":
                return typeof(char);
            case "byte":
                return typeof(byte);
            case "Byte":
                return typeof(byte);
            case "sbyte":
                return typeof(sbyte);
            case "SByte":
                return typeof(sbyte);
            case "short":
                return typeof(short);
            case "Int16":
                return typeof(short);
            case "long":
                return typeof(long);
            case "Int64":
                return typeof(long);
            case "ushort":
                return typeof(ushort);
            case "UInt16":
                return typeof(ushort);
            case "uint":
                return typeof(uint);
            case "UInt32":
                return typeof(uint);
            case "ulong":
                return typeof(ulong);
            case "UInt64":
                return typeof(ulong);
        }
        throw new Exception($"Unsupported type name: '{typeName}'");
    }
}