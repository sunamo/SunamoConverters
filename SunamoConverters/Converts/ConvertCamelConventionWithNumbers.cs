// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts text to and from camel case convention with number support.
/// </summary>
public class ConvertCamelConventionWithNumbers
{
    /// <summary>
    /// Checks if the text is in camel case format with numbers.
    /// </summary>
    /// <param name="text">The text to check.</param>
    /// <returns>True if the text is in camel case with numbers, false otherwise.</returns>
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
    /// Converts text to camel case convention (does not include numbers).
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The text converted to camel case.</returns>
    public static string ToConvention(string text)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));
    }

    /// <summary>
    /// Converts text from camel case convention to regular text.
    /// </summary>
    /// <param name="text">The camel case text to convert.</param>
    /// <param name="isFirstCharUpper">If true, the first character will be uppercase.</param>
    /// <returns>The text converted from camel case.</returns>
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