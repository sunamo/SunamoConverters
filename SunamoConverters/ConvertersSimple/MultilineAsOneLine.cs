namespace SunamoConverters.ConvertersSimple;

public class MultilineAsOneLine
{
    public const string R = "\r";
    public const string N = "\n";
    public const string RR = "\\r";

    public static string ConvertTo(string input)
    {
        return input.Replace(N, string.Empty).Replace(R, RR);
    }

    public static string ConvertFrom(string input)
    {
        return input.Replace(RR, R);
    }
}