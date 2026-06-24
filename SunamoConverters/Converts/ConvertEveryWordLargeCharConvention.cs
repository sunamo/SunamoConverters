namespace SunamoConverters.Converts;

public class ConvertEveryWordLargeCharConvention //: IConvertConvention
{
    public static string ToConvention(string text)
    {
        text = text.ToLower();
        var stringBuilder = new StringBuilder();
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
        var result = stringBuilder.ToString().Trim();

        result = result.Replace("  ", " "); //SHReplace.ReplaceAll(result, " ", "");
        return result;
    }

    private static bool IsSpecialChar(char character)
        => new List<char>(['\\', '(', ')', ']', '[', '.', '\'']).Any(specialChar => specialChar == character);
}
