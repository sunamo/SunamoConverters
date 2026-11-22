namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Represents the multiline as one line type.
/// </summary>
public class MultilineAsOneLine
{
    /// <summary>
    /// The r constant.
    /// </summary>
    public const string R = "\r";

    /// <summary>
    /// The n constant.
    /// </summary>
    public const string N = "\n";

    /// <summary>
    /// The RR constant.
    /// </summary>
    public const string RR = "\\r";

    /// <summary>
    /// Convert to.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>The convert to result.</returns>
    public static string ConvertTo(string input)
    {
        // Every kind of line break (CRLF, LF, CR) becomes one token, so no line break is lost.
        return (input ?? string.Empty).Replace(R + N, R).Replace(N, R).Replace(R, RR);
    }

    /// <summary>
    /// The NN constant: a line break token written by older app files.
    /// </summary>
    public const string NN = "\\n";

    /// <summary>
    /// Converts one-line text back to multiline text with the given line break; reads both the \r and the \n token.
    /// </summary>
    /// <param name="input">The one-line text.</param>
    /// <param name="newLine">The line break to put in place of every token.</param>
    /// <returns>The multiline text.</returns>
    public static string ConvertFrom(string input, string newLine)
    {
        return (input ?? string.Empty).Replace(RR + NN, newLine).Replace(RR, newLine).Replace(NN, newLine);
    }

    /// <summary>
    /// Convert from.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>The convert from result.</returns>
    public static string ConvertFrom(string input)
    {
        return input.Replace(RR, R);
    }
}
