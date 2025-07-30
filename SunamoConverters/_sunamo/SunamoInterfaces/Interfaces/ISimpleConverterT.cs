namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;


internal interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U u);
    U ConvertFrom(TypeInClassName t);
}