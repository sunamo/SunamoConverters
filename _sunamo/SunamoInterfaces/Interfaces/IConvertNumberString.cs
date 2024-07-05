namespace SunamoConverters._sunamo.SunamoInterfaces.Interfaces;


internal interface IConvertNumberString
{
    int ToNumber(string s);
    string ToString(int number);
}