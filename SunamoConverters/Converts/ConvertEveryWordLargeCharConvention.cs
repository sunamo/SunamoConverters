namespace SunamoConverters.Converts;

public class ConvertEveryWordLargeCharConvention //: IConvertConvention
{
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
    /// <param name="text"></param>
    public static string ToConvention(string text)
    {
        text = text.ToLower();
        StringBuilder stringBuilder = new StringBuilder();
        bool isNextCharUpperCase = true;
        foreach (char item in text)
        {
            if (isNextCharUpperCase)
            {
                if (char.IsUpper(item))
                {
                    isNextCharUpperCase = false;
                    stringBuilder.Append(' ');
                    stringBuilder.Append(item);
                    continue;
                }
                else if (char.IsLower(item))
                {
                    isNextCharUpperCase = false;
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
                isNextCharUpperCase = true;
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
                isNextCharUpperCase = true;
            }
        }
        string result = stringBuilder.ToString().Trim();

        result = result.Replace("  ", " "); //SHReplace.ReplaceAll(result, " ", "");
        return result;
    }

    private static bool IsSpecialChar(char character)
    {
        return new List<char>(['\\', '(', ')', ']', '[', '.', '\'']).Any(d => d == character); //CAG.IsEqualToAnyElement<char>(item, );
    }
}