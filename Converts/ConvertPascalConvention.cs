namespace SunamoConverters.Converts;

public class ConvertPascalConvention //: IConvertConvention
{
    /// <summary>
    /// NI
    /// </summary>
    /// <param name="p"></param>
    public static string FromConvention(string p)
    {
        //ThrowEx.NotImplementedMethod();
        return SH.FirstCharUpper(Regex.Replace(p, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}").ToLower());
    }
    public static bool IsPascal(string r)
    {
        var s = ToConvention(r);
        return r == s;
    }

    /// <summary>
    /// Will include numbers
    /// hello world = HelloWorld
    /// Hello world = HelloWorld
    /// helloWorld = HelloWorld
    /// </summary>
    /// <param name="p"></param>
    public static string ToConvention(string p)
    {
        StringBuilder sb = new StringBuilder();
        bool dalsiVelke = false;
        foreach (char item in p)
        {
            if (dalsiVelke)
            {
                if (char.IsUpper(item))
                {
                    dalsiVelke = false;
                    sb.Append(item);
                    continue;
                }
                else if (char.IsLower(item))
                {
                    dalsiVelke = false;
                    sb.Append(char.ToUpper(item));
                    continue;
                }
                else if (char.IsDigit(item))
                {
                    dalsiVelke = true;
                    sb.Append(item);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            if (char.IsUpper(item))
            {
                sb.Append(item);
            }
            else if (char.IsLower(item))
            {
                sb.Append(item);
            }
            else if (char.IsDigit(item))
            {
                sb.Append(item);
            }
            else
            {
                dalsiVelke = true;
            }
        }
        var result = sb.ToString().Trim();
        StringBuilder sb2 = new StringBuilder(result);
        sb2[0] = char.ToUpper(sb2[0]);
        //result = SH.FirstCharUpper(result);
        return result;
    }
}
