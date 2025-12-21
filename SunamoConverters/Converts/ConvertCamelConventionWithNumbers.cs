namespace SunamoConverters.Converts;

public class ConvertCamelConventionWithNumbers
{
    public static bool IsCamelWithNumber(string result)
    {
        if (result.ToLower() == result && !result.Contains(" "))
        {
            return true;
        }
        var text = ToConvention(result);

        return text == result;
    }

    /// <summary>
    /// wont include numbers
    /// </summary>
    /// <param name="p"></param>
    public static string ToConvention(string p)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(p));
    }

    public static string FromConvention(string p, bool firstCharUpper = false)
    {
        var result = Regex.Replace(p, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}").ToLower();
        if (firstCharUpper)
        {
            var stringBuilder = new StringBuilder(result);
            stringBuilder[0] = char.ToUpper(stringBuilder[0]);

            return stringBuilder.ToString();
        }
        return result;
    }
}