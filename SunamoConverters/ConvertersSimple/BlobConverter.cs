namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Converts between byte arrays and hexadecimal string representation.
/// </summary>
public class BlobConverter : ISimpleConverterT<string, byte[]>
{
    /// <summary>
    /// Converts a byte array to a hexadecimal string representation.
    /// </summary>
    /// <param name="value">The byte array to convert.</param>
    /// <returns>A hexadecimal string representation of the byte array.</returns>
    public string ConvertTo(byte[] value)
    {
        if (value == null || value.Length == 0)
        {
            return "";
        }
        const string HexFormat = "{0:X2}";
        StringBuilder stringBuilder = new StringBuilder();
        foreach (byte byteValue in value)
        {
            stringBuilder.Append(string.Format(HexFormat, byteValue.ToString()));
        }
        return "X'" + stringBuilder.ToString() + "'";
    }

    /// <summary>
    /// Converts a hexadecimal string representation to a byte array.
    /// </summary>
    /// <param name="value">The hexadecimal string to convert.</param>
    /// <returns>The byte array representation, or null if input is null or empty.</returns>
    /// <exception cref="Exception">Thrown when the string is not properly hex-encoded.</exception>
    public byte[]? ConvertFrom(string value)
    {
        if (value == null || value.Length == 0)
        {
            return null;
        }
        try
        {
            value = value.Replace("X'", "").TrimEnd('\\');

            int byteCount = Convert.ToInt32(value.Length / 2);
            byte[] buffer = new byte[byteCount];
            for (int i = 0; i <= byteCount - 1; i++)
            {
                buffer[i] = Convert.ToByte(value.Substring(i * 2, 2), 16);
            }
            return buffer;
        }
        catch (Exception ex)
        {
            ThrowEx.Custom(ex);
            throw new Exception($"{XTheProvidedStringDoesNotAppearToBeHexEncoded}: {value}");
        }
    }

    /// <summary>
    /// Error message constant for when a string cannot be decoded as hex.
    /// </summary>
    public static string XTheProvidedStringDoesNotAppearToBeHexEncoded = "TheProvidedStringDoesNotAppearToBeHexEncoded";
}