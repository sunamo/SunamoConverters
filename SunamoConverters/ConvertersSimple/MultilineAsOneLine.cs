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
        return input.Replace(N, string.Empty).Replace(R, RR);
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
