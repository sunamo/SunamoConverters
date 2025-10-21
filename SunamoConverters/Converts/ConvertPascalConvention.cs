// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

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
        var text = ToConvention(r);
        return r == text;
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
        StringBuilder stringBuilder = new StringBuilder();
        bool dalsiVelke = false;
        foreach (char item in p)
        {
            if (dalsiVelke)
            {
                if (char.IsUpper(item))
                {
                    dalsiVelke = false;
                    stringBuilder.Append(item);
                    continue;
                }
                else if (char.IsLower(item))
                {
                    dalsiVelke = false;
                    stringBuilder.Append(char.ToUpper(item));
                    continue;
                }
                else if (char.IsDigit(item))
                {
                    dalsiVelke = true;
                    stringBuilder.Append(item);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            if (char.IsUpper(item))
            {
                stringBuilder.Append(item);
            }
            else if (char.IsLower(item))
            {
                stringBuilder.Append(item);
            }
            else if (char.IsDigit(item))
            {
                stringBuilder.Append(item);
            }
            else
            {
                dalsiVelke = true;
            }
        }
        var result = stringBuilder.ToString().Trim();
        StringBuilder sb2 = new StringBuilder(result);
        sb2[0] = char.ToUpper(sb2[0]);
        //result = SH.FirstCharUpper(result);
        return result;
    }
}
