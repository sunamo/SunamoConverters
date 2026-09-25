namespace SunamoConverters.Converts;

public class ConvertPascalConvention
{
    public static string FromConvention(string text)
        => SH.FirstCharUpper(Regex.Replace(text, "[a-z][A-Z]", match => $"{match.Value[0]} {char.ToLower(match.Value[1])}").ToLower());

    public static bool IsPascal(string text)
    {
        var convertedText = ToConvention(text);
        return text == convertedText;
    }

    public static string ToConvention(string text)
    {
        var stringBuilder = new StringBuilder();
        bool isNextCharUpperCase = false;
        foreach (char character in text)
        {
            if (isNextCharUpperCase)
            {
                if (char.IsUpper(character))
                {
                    isNextCharUpperCase = false;
                    stringBuilder.Append(character);
                    continue;
                }
                else if (char.IsLower(character))
                {
                    isNextCharUpperCase = false;
                    stringBuilder.Append(char.ToUpper(character));
                    continue;
                }
                else if (char.IsDigit(character))
                {
                    isNextCharUpperCase = true;
                    stringBuilder.Append(character);
                    continue;
                }
                else
                {
                    continue;
                }
            }
            if (char.IsUpper(character))
            {
                stringBuilder.Append(character);
            }
            else if (char.IsLower(character))
            {
                stringBuilder.Append(character);
            }
            else if (char.IsDigit(character))
            {
                stringBuilder.Append(character);
            }
            else
            {
                isNextCharUpperCase = true;
            }
        }
        var result = stringBuilder.ToString().Trim();
        if (result.Length > 0)
        {
            var resultBuilder = new StringBuilder(result);
            resultBuilder[0] = char.ToUpper(resultBuilder[0]);
            return resultBuilder.ToString();
        }
        return result;
    }
}
