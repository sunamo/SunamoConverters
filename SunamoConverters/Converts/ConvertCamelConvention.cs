namespace SunamoConverters.Converts;

/// <summary>
/// Represents the convert camel convention type.
/// </summary>
public class ConvertCamelConvention
{
    /// <summary>
    /// Is camel.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The is camel result.</returns>
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
    /// To convention.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The to convention result.</returns>
    public static string ToConvention(string text)
    {
        return SH.FirstCharLower(ConvertPascalConvention.ToConvention(text));
    }
}
