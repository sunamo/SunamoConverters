namespace SunamoConverters;


public class PropertyTypesConverter : ISimpleConverterT<PropertyTypes, string>
{
    static Type type = typeof(PropertyTypesConverter);

    public PropertyTypes ConvertTo(string u)
    {
        ThrowEx.NotImplementedMethod();
        return PropertyTypes.Bool;
    }

    /// <summary>
    /// Dont implement all, see usage in other code
    /// </summary>
    /// <param name="t"></param>
    public string ConvertFrom(PropertyTypes t)
    {
        switch (t)
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
