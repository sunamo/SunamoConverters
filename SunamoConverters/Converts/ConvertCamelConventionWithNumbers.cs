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

    /// <summary>
    /// wont include numbers
    /// </summary>
    /// <param name="text"></param>
    public static string ToConvention(string text)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));
    }

    public static string FromConvention(string text, bool isFirstCharUpper = false)
    {
        var result = Regex.Replace(text, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}").ToLower();
        if (isFirstCharUpper)
        {
            var stringBuilder = new StringBuilder(result);
            stringBuilder[0] = char.ToUpper(stringBuilder[0]);

            return stringBuilder.ToString();
        }
        return result;
    }
}