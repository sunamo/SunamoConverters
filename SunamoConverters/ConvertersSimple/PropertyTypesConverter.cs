// variables names: ok
namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Converts between PropertyTypes enum and their full type names.
/// </summary>
public class PropertyTypesConverter : ISimpleConverterT<PropertyTypes, string>
{
    /// <summary>
    /// Converts a type name string to PropertyTypes enum.
    /// </summary>
    /// <param name="text">The type name string.</param>
    /// <returns>The corresponding PropertyTypes enum value.</returns>
    public PropertyTypes ConvertTo(string text)
    {
        ThrowEx.NotImplementedMethod();
        return PropertyTypes.Bool;
    }

    /// <summary>
    /// Converts a PropertyTypes enum value to its full System type name string.
    /// Note: Not all PropertyTypes values are implemented - see usage in calling code.
    /// </summary>
    /// <param name="propertyType">The PropertyTypes enum value to convert.</param>
    /// <returns>The full System type name (e.g., "System.String", "System.UInt64"), or empty string for unimplemented types.</returns>
    public string ConvertFrom(PropertyTypes propertyType)
    {
        switch (propertyType)
        {
            case PropertyTypes.ULong:
                return "System.UInt64";
            case PropertyTypes.UInt:
                return "System.UInt32";
            case PropertyTypes.UShort:
                return "System.UInt16";
            case PropertyTypes.Byte:
                return "System.Byte";
            case PropertyTypes.String:
                return "System.String";
            case PropertyTypes.Double:
                return "System.Double";
            case PropertyTypes.Float:
                return "System.Single";
            case PropertyTypes.DateTime:
                return "System.DateTime";
            case PropertyTypes.Bool:
                return "System.Boolean";
            default:
                return "";
        }
    }
}