namespace SunamoConverters.ConvertersSimple;

/// <summary>
/// Represents the blob converter type.
/// </summary>
public class BlobConverter : ISimpleConverterT<string, byte[]>
{
    /// <summary>
    /// Convert to.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The convert to result.</returns>
    public string ConvertTo(byte[] value)
    {
        if (value == null || value.Length == 0)
        {
            return "";
        }
        const string HexFormat = "{0:X2}";
        var stringBuilder = new StringBuilder();
        foreach (byte byteValue in value)
        {
            stringBuilder.Append(string.Format(HexFormat, byteValue.ToString()));
        }
        return "X'" + stringBuilder.ToString() + "'";
    }

    /// <summary>
    /// Convert from.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The convert from result.</returns>
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
    /// The x the provided string does not appear to be hex encoded.
    /// </summary>
    public static string XTheProvidedStringDoesNotAppearToBeHexEncoded = "TheProvidedStringDoesNotAppearToBeHexEncoded";
}
