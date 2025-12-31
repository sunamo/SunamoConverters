namespace SunamoConverters.ConvertersSimple;

public class BlobConverter : ISimpleConverterT<string, byte[]>
{
    public string ConvertTo(byte[] value)
    {
        if (value == null || value.Length == 0)
        {
            return "";
        }
        const string HexFormat = "{0:X2}";
        StringBuilder stringBuilder = new StringBuilder();
        foreach (byte buffer in value)
        {
            stringBuilder.Append(/*string.Format*/ string.Format(HexFormat, buffer.ToString()));
        }
        return "X'" + stringBuilder.ToString() + "'";
    }

    public byte[] ConvertFrom(string value)
    {
        if (value == null || value.Length == 0)
        {
            return null;
        }
        try
        {
            value = value.Replace("X'", "").TrimEnd('\\'); ;

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
            //if (AppLangHelper.currentUICulture.TwoLetterISOLanguageName == "cs")
            //{
            //    throw new Exception("Zadan\u00FD \u0159et\u011Bzec se nezd\u00E1 buffer\u00FDt \u0161estn\u00E1ctkov\u011B k\u00F3dov\u00E1n\u00FD:");
            //    return null;
            //}
            //else
            //{
            throw new Exception(XTheProvidedStringDoesNotAppearToBeHexEncoded + ":" + value);
            return null;
            //}
        }
    }

    public static string XTheProvidedStringDoesNotAppearToBeHexEncoded = "TheProvidedStringDoesNotAppearToBeHexEncoded";
}