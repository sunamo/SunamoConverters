namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Converts multiline text to single line representation and vice versa.
/// </summary>
public class MultilineAsOneLine
{
    /// <summary>
    /// Carriage return character constant.
    /// </summary>
    public const string R = "\r";

    /// <summary>
    /// Newline character constant.
    /// </summary>
    public const string N = "\n";

    /// <summary>
    /// Escaped carriage return string constant.
    /// </summary>
    public const string RR = "\\r";

    /// <summary>
    /// Converts multiline text to single line by replacing newlines with escaped carriage returns.
    /// </summary>
    /// <param name="input">The multiline text to convert.</param>
    /// <returns>The text as a single line.</returns>
    public static string ConvertTo(string input)
    {
        return input.Replace(N, string.Empty).Replace(R, RR);
    }

    /// <summary>
    /// Converts single line text back to multiline by replacing escaped carriage returns with actual carriage returns.
    /// </summary>
    /// <param name="input">The single line text to convert.</param>
    /// <returns>The text with actual line breaks.</returns>
    public static string ConvertFrom(string input)
    {
        return input.Replace(RR, R);
    }
}