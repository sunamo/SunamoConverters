namespace SunamoConverters.Converts;

/// <summary>
/// Converts text to and from Pascal case convention (EachWordStartsWithCapital).
/// </summary>
public class ConvertPascalConvention
{
    /// <summary>
    /// Converts text from Pascal case to separate words.
    /// </summary>
    /// <param name="text">The Pascal case text to convert.</param>
    /// <returns>The text with words separated by spaces.</returns>
    public static string FromConvention(string text)
    {
        return SH.FirstCharUpper(Regex.Replace(text, "[a-z][A-Z]", match => $"{match.Value[0]} {char.ToLower(match.Value[1])}").ToLower());
    }

    /// <summary>
    /// Checks if the text is in Pascal case format.
    /// </summary>
    /// <param name="text">The text to check.</param>
    /// <returns>True if the text is in Pascal case, false otherwise.</returns>
    public static bool IsPascal(string text)
    {
        var convertedText = ToConvention(text);
        return text == convertedText;
    }

    /// <summary>
    /// Converts text to Pascal case convention (includes numbers).
    /// Examples:
    /// - "hello world" → "HelloWorld"
    /// - "Hello world" → "HelloWorld"
    /// - "helloWorld" → "HelloWorld"
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The text converted to Pascal case.</returns>
    public static string ToConvention(string text)
    {
        StringBuilder stringBuilder = new StringBuilder();
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
            StringBuilder resultBuilder = new StringBuilder(result);
            resultBuilder[0] = char.ToUpper(resultBuilder[0]);
            return resultBuilder.ToString();
        }
        return result;
    }
}