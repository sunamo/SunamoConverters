namespace SunamoConverters.Converts;

public class ConvertSnakeConvention
{
    static string Sanitize(string input)
    {
        var text = new StringBuilder(input.Replace(" ", "_").Replace("__", "_"));
        for (int i = text.Length - 1; i >= 0; i--)
        {
            var ch = text[i];
            if (!char.IsLetter(ch) && !char.IsDigit(ch) && ch != '_')
            {
                text = text.Remove(i, 1);
            }
        }
        return text.ToString();
    }
    public static string ToConvention(string input)
    {
        var rz = string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        return Sanitize(rz);
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }
        if (input.Length < 2)
        {
            return input;
        }
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(char.ToLowerInvariant(input[0]));
        for (int i = 1; i < input.Length; ++i)
        {
            char character = input[i];
            if (char.IsUpper(character))
            {
                stringBuilder.Append('_');
                stringBuilder.Append(char.ToLowerInvariant(character));
            }
            else
            {
                stringBuilder.Append(character);
            }
        }
        var result = stringBuilder.ToString().Replace(" ", "_");
        return result;
    }
    //public static string FromConvention(string p)

    //{
    //    ThrowEx.Custom("Zkusit knihovnu třetích stran");
    //    return null;
    //    //    var pa = p.Split('_'); //SHSplit.SplitChar(p, new Char[] { '_' });
    //    //CA.ToLower(pa);
    //    //    CAChangeContent.ChangeContent0(null, pa, SH.FirstCharUpper);
    //    //    return string.Join("", pa);
    //}
}