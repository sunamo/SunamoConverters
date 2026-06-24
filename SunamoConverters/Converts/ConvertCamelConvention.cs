namespace SunamoConverters.Converts;

public class ConvertCamelConvention
{
    public static bool IsCamel(string text)
    {
        if (text.ToLower() == text)
        {
            return false;
        }
        var convertedText = ToConvention(text);
        return convertedText == text;
    }

    public static string ToConvention(string text)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));
    }
}
