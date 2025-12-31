namespace SunamoConverters.Converts;

public class ConvertPascalConvention //: IConvertConvention
{
    /// <summary>
    /// NI
    /// </summary>
    /// <param name="text"></param>
    public static string FromConvention(string text)
    {
        //ThrowEx.NotImplementedMethod();
        return SH.FirstCharUpper(Regex.Replace(text, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m. Value[1])}").ToLower());
    }
    public static bool IsPascal(string text)
    {
        var convertedText = ToConvention(text);
        return text == convertedText;
    }

    /// <summary>
    /// Will include numbers
    /// hello world = HelloWorld
    /// Hello world = HelloWorld
    /// helloWorld = HelloWorld
    /// </summary>
    /// <param name="text"></param>
    public static string ToConvention(string text)
    {
        StringBuilder stringBuilder = new StringBuilder();
        bool isNextCharUpperCase = false;
        foreach (char item in text)
        {
            if (isNextCharUpperCase)
            {
                if (char.IsUpper(item))
                {
                    isNextCharUpperCase = false;
                    stringBuilder.Append(item);
                    continue;
                }
                else if (char.IsLower(item))
                {
                    isNextCharUpperCase = false;
                    stringBuilder.Append(char.ToUpper(item));
                    continue;
                }
                else if (char.IsDigit(item))
                {
                    isNextCharUpperCase = true;
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
                isNextCharUpperCase = true;
            }
        }
        var result = stringBuilder.ToString().Trim();
        StringBuilder resultBuilder = new StringBuilder(result);
        resultBuilder[0] = char.ToUpper(resultBuilder[0]);
        //result = SH.FirstCharUpper(result);
        return result;
    }
}