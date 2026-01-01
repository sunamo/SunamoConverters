namespace SunamoConverters.Converts;

/// <summary>
/// Converts text to and from a format where uppercase letters are replaced with a marker followed by lowercase.
/// Uses '$' as the marker for uppercase letters.
/// </summary>
public class ConvertOnlyLowercase
{
    /// <summary>
    /// Marker character used to indicate the next letter should be uppercase.
    /// Note: '%' causes HTTP Error 400 (invalid URL), '*' is potentially dangerous.
    /// </summary>
    public static char NextUpper = '$';

    /// <summary>
    /// Converts text to lowercase-only format.
    /// Replaces each uppercase letter with the NextUpper marker followed by its lowercase version.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The converted text with all uppercase letters replaced.</returns>
    public static string To(string text)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in text)
        {
            if (char.IsUpper(item))
            {
                stringBuilder.Append(NextUpper);
                stringBuilder.Append(char.ToLower(item));
            }
            else
            {
                stringBuilder.Append(item);
            }
        }

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Converts text from lowercase-only format back to original.
    /// When NextUpper marker ('$') is found, the next character will be converted to uppercase.
    /// </summary>
    /// <param name="text">The text to convert back.</param>
    /// <returns>The original text with uppercase letters restored.</returns>
    public static string From(string text)
    {
        bool isNextCharUpper = false;
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in text)
        {
            if (isNextCharUpper)
            {
                isNextCharUpper = false;
                stringBuilder.Append(char.ToUpper(item));
                continue;
            }

            if (item == NextUpper)
            {
                isNextCharUpper = true;
            }
            else
            {
                stringBuilder.Append(item);
            }
        }

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Pre-processed conversions for letters.
    /// </summary>
    private static Dictionary<char, char>? conversionMap;

    /// <summary>
    /// Encodes text using a custom letter conversion and number reversal algorithm.
    /// </summary>
    /// <param name="text">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static string Encode(string text)
    {

        // approach: pre process a mapping (dictionary) for letter conversions
        // use a Dict for fastest look ups.  The first run, will take a little
        // extra time, subsequent usage will perform even better
        if (conversionMap == null || conversionMap.Count == 0) BuildConversionMappings();

        // our return val (efficient Appends)
        StringBuilder stringBuilder = new StringBuilder();

        // used for reversing the numbers
        Stack<char> nums = new Stack<char>();

        // iterate the input string
        for (int i = 0; i < text.Length; i++)
        {

            char character = text[i];

            // we have 3 cases:
            // 1) is alpha ==> convert using mapping
            // 2) is number ==> peek ahead to complete the number
            // 3) is special char / punctunation ==> ignore

            if (conversionMap!.ContainsKey(character))
            {
                stringBuilder.Append(conversionMap[character]);
                continue;
            }

            if (Char.IsDigit(character))
            {
                nums.Push(character);

                // we've reached the end of the input string OR
                // we've reached the end of the number
                if (i == text.Length - 1
                || !Char.IsDigit(text[i + 1]))
                {
                    while (nums.Count > 0)
                    {
                        stringBuilder.Append(nums.Pop());
                    }
                }

                continue;
            }

            // not letter, not digit
            stringBuilder.Append(character);
        }
        return stringBuilder.ToString();
    }

    // create our mappings for letters
    private static void BuildConversionMappings()
    {

        conversionMap = new Dictionary<char, char>();

        // only loop once for both
        for (char character = 'B'; character <= 'Z'; character++)
        {
            // add capitals version
            char val = (char)(character - 1);
            val = Char.ToLower(val);
            conversionMap.Add(character, val);
            // add lower case version
            conversionMap.Add(Char.ToLower(character), val);
        }

        // special cases
        conversionMap['y'] = ' ';
        conversionMap['Y'] = ' ';
        conversionMap.Add(' ', 'y');

        // vowels
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < vowels.Length; i++)
        {
            var letter = vowels[i];
            var value = (i + 1).ToString()[0];
            conversionMap[letter] = value;
            conversionMap[Char.ToUpper(letter)] = value;
        }
    }
}