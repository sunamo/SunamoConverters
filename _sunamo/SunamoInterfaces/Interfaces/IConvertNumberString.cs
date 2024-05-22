namespace SunamoConverters;


internal interface IConvertNumberString
{
    int ToNumber(string s);
    string ToString(int number);
}