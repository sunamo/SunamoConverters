// variables names: ok
namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;

internal interface IConvertNumberString
{
    int ToNumber(string text);
    string ToString(int number);
}