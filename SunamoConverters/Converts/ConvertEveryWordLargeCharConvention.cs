namespace SunamoConverters.Converts;

public class ConvertEveryWordLargeCharConvention //: IConvertConvention
{
    static Type type = typeof(ConvertEveryWordLargeCharConvention);



    /// <summary>
    /// hello world => Hello World
    /// Hello world => Hello World
    /// helloWorld => Hello World
    /// hello+world => Hello World
    /// hello+World => Hello World
    /// hello 12 world => Hello 12 World
    /// hello 21world => Hello 21 World
    /// Hello21world => Hello21 World
    /// </summary>
    /// <param name="p"></param>
    public static string ToConvention(string p)
    {
        p = p.ToLower();
        StringBuilder stringBuilder = new StringBuilder();
        bool dalsiVelke = true;
        foreach (char item in p)
        {
            if (dalsiVelke)
            {
                if (char.IsUpper(item))
                {
                    dalsiVelke = false;
                    stringBuilder.Append(' ');
                    stringBuilder.Append(item);
                    continue;
                }
                else if (char.IsLower(item))
                {
                    dalsiVelke = false;
                    if (stringBuilder.Length != 0)
                    {
                        if (!IsSpecialChar(stringBuilder[stringBuilder.Length - 1]))
                        {
                            stringBuilder.Append(' ');
                        }
                    }
                    stringBuilder.Append(char.ToUpper(item));
                    continue;
                }
                else if (IsSpecialChar(item))
                {
                    stringBuilder.Append(item);
                    continue;
                }
                else if (char.IsDigit(item))
                {
                    stringBuilder.Append(item);
                    continue;
                }
                else
                {
                    stringBuilder.Append(' ');
                    continue;
                }
            }
            if (char.IsUpper(item))
            {
                if (!char.IsUpper(stringBuilder[stringBuilder.Length - 1]))
                {
                    stringBuilder.Append(' ');
                }
                stringBuilder.Append(item);
            }
            else if (char.IsLower(item))
            {
                stringBuilder.Append(item);
            }
            else if (char.IsDigit(item))
            {
                dalsiVelke = true;
                stringBuilder.Append(item);
                continue;
            }
            else if (IsSpecialChar(item))
            {
                stringBuilder.Append(item);
                continue;
            }
            else
            {
                stringBuilder.Append(' ');
                dalsiVelke = true;
            }
        }
        string vr = stringBuilder.ToString().Trim();

        vr = vr.Replace("  ", " "); //SHReplace.ReplaceAll(vr, " ", "");
        return vr;
    }

    private static bool IsSpecialChar(char item)
    {
        return new List<char>(['\\', '(', ')', ']', '[', '.', '\'']).Any(d => d == item); //CAG.IsEqualToAnyElement<char>(item, );
    }
}