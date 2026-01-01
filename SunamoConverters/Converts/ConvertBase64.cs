namespace SunamoConverters.Converts;

/// <summary>
/// Converts text between plain format and Base64 encoding.
/// </summary>
public class ConvertBase64
{
    /// <summary>
    /// Encodes plain text to Base64 format.
    /// </summary>
    /// <param name="plainText">The plain text to encode.</param>
    /// <returns>The Base64 encoded string.</returns>
    public static string To(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    /// <summary>
    /// Decodes Base64 encoded data to plain text.
    /// </summary>
    /// <param name="base64EncodedData">The Base64 encoded string.</param>
    /// <returns>The decoded plain text.</returns>
    public static string From(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        string result = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        return result;
    }
}