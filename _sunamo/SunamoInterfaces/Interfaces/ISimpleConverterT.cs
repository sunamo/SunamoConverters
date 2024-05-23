namespace SunamoConverters;


public interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U u);
    U ConvertFrom(TypeInClassName t);
}