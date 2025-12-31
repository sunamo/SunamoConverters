namespace SunamoConverters.ConvertersSimple;

public class PropertyTypesConverter : ISimpleConverterT<PropertyTypes, string>
{
    public PropertyTypes ConvertTo(string text)
    {
        ThrowEx.NotImplementedMethod();
        return PropertyTypes.Bool;
    }

    /// <summary>
    /// Dont implement all, see usage in other code
    /// </summary>
    /// <param name="propertyType"></param>
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