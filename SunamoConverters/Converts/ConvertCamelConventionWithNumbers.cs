namespace SunamoConverters.Converts;

public class ConvertCamelConventionWithNumbers
{
    public static bool IsCamelWithNumber(string text)
    {
        if (text.ToLower() == text && !text.Contains(" "))
        {
            return true;
        }
        var convertedText = ToConvention(text);

        return convertedText == text;
    }

    public static string ToConvention(string text)
        => SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));

    public static string FromConvention(string text, bool isFirstCharUpper = false)
    {
        var result = Regex.Replace(text, "[a-z][A-Z]", match => $"{match.Value[0]} {char.ToLower(match.Value[1])}").ToLower();
        if (isFirstCharUpper)
        {
            var stringBuilder = new StringBuilder(result);
            stringBuilder[0] = char.ToUpper(stringBuilder[0]);

            return stringBuilder.ToString();
        }
        return result;
    }
}
