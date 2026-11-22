namespace SunamoConverters.Converts;

/// <summary>
/// Represents the convert base 64 type.
/// </summary>
public class ConvertBase64
{
    /// <summary>
    /// To.
    /// </summary>
    /// <param name="plainText">The plain text.</param>
    /// <returns>The to result.</returns>
    public static string To(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    /// <summary>
    /// From.
    /// </summary>
    /// <param name="base64EncodedData">The base 64 encoded data.</param>
    /// <returns>The from result.</returns>
    public static string From(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        string result = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        return result;
    }
}
