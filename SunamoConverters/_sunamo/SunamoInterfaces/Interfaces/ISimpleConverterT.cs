namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;

internal interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U value);
    U ConvertFrom(TypeInClassName value);
}