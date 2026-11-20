namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Represents the property types converter type.
/// </summary>
public class PropertyTypesConverter : ISimpleConverterT<PropertyTypes, string>
{
    /// <summary>
    /// Convert to.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The convert to result.</returns>
    public PropertyTypes ConvertTo(string text)
    {
        ThrowEx.NotImplementedMethod();
        return PropertyTypes.Bool;
    }

    /// <summary>
    /// Convert from.
    /// </summary>
    /// <param name="propertyType">The property type.</param>
    /// <returns>The convert from result.</returns>
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
