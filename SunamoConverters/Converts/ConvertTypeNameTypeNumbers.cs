namespace SunamoConverters.Converts;

/// <summary>
/// Converts numeric type names to System.Type objects.
/// </summary>
public class ConvertTypeNameTypeNumbers
{
    /// <summary>
    /// Converts a numeric type name string to a System.Type.
    /// Returns null if the type is not a supported numeric type.
    /// When comparing the obtained type, use typeof(int, string, byte) not typeof(Int32, String, Byte).
    /// The input string must be without "System." prefix.
    /// </summary>
    /// <param name="typeName">The type name to convert (e.g., "int", "Int32", "float", "Single").</param>
    /// <returns>The corresponding System.Type, or null if the type is not a supported numeric type.</returns>
    public static Type? ToType(string typeName)
    {
        switch (typeName)
        {
            case "int":
                return typeof(int);
            case "Int32":
                return typeof(int);
            case "float":
                return typeof(float);
            case "Single":
                return typeof(float);
            case "double":
                return typeof(double);
            case "Double":
                return typeof(double);
            case "decimal":
                return typeof(decimal);
            case "Decimal":
                return typeof(decimal);
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
        return null;
    }
}