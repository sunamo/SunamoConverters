namespace SunamoConverters.Converts;

/// <summary>
/// Converts text to and from camel case convention (firstWordLowerCase).
/// </summary>
public class ConvertCamelConvention
{
    /// <summary>
    /// Checks if the text is in camel case format.
    /// </summary>
    /// <param name="text">The text to check.</param>
    /// <returns>True if the text is in camel case, false otherwise.</returns>
    public static bool IsCamel(string text)
    {
        if (text.ToLower() == text)
        {
            return false;
        }
        var convertedText = ToConvention(text);
        return convertedText == text;
    }

    /// <summary>
    /// Converts text to camel case convention (includes numbers).
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The text converted to camel case.</returns>
    public static string ToConvention(string text)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));
    }
}