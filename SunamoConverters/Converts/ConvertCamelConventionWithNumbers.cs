namespace SunamoConverters.Converts;

/// <summary>
/// Represents the convert camel convention with numbers type.
/// </summary>
public class ConvertCamelConventionWithNumbers
{
    /// <summary>
    /// Is camel with number.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The is camel with number result.</returns>
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
    /// To convention.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The to convention result.</returns>
    public static string ToConvention(string text)
        => SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));

    /// <summary>
    /// From convention.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="isFirstCharUpper">The is first char upper.</param>
    /// <returns>The from convention result.</returns>
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
