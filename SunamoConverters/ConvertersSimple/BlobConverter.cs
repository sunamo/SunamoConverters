// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoConverters.ConvertersSimple;

public class BlobConverter : ISimpleConverterT<string, byte[]>
{
    public string ConvertTo(byte[] ba)
    {
        if (ba == null || ba.Length == 0)
        {
            return "";
        }
        const string HexFormat = "{0:X2}";
        StringBuilder stringBuilder = new StringBuilder();
        foreach (byte buffer in ba)
        {
            stringBuilder.Append(/*string.Format*/ string.Format(HexFormat, buffer.ToString()));
        }
        return "X'" + stringBuilder.ToString() + "'";
    }

    static Type type = typeof(BlobConverter);
    public byte[] ConvertFrom(string hexEncoded)
    {
        if (hexEncoded == null || hexEncoded.Length == 0)
        {
            return null;
        }
        try
        {
            hexEncoded = hexEncoded.Replace("X'", "").TrimEnd('\\'); ;

            int l = Convert.ToInt32(hexEncoded.Length / 2);
            byte[] buffer = new byte[l];
            for (int i = 0; i <= l - 1; i++)
            {
                buffer[i] = Convert.ToByte(hexEncoded.Substring(i * 2, 2), 16);
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
            throw new Exception(xTheProvidedStringDoesNotAppearToBeHexEncoded + ":" + hexEncoded);
            return null;
            //}
        }
    }

    public static string xTheProvidedStringDoesNotAppearToBeHexEncoded = "TheProvidedStringDoesNotAppearToBeHexEncoded";
}
