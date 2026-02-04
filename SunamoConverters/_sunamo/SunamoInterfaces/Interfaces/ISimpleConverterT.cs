namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;

internal interface ISimpleConverterT<TOutput, TInput>
{
    TOutput ConvertTo(TInput value);
    TInput? ConvertFrom(TOutput value);
}