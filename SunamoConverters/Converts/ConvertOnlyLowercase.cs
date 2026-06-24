namespace SunamoConverters.Converts;

public class ConvertOnlyLowercase
{
    // Note: '%' causes HTTP Error 400 (invalid URL), '*' is potentially dangerous.
    public static char NextUpper = '$';

    public static string To(string text)
    {
        var stringBuilder = new StringBuilder();
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

    public static string From(string text)
    {
        bool isNextCharUpper = false;
        var stringBuilder = new StringBuilder();
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

    private static Dictionary<char, char>? conversionMap;

    public static string Encode(string text)
    {
        // approach: pre process a mapping (dictionary) for letter conversions
        // use a Dict for fastest look ups.  The first run, will take a little
        // extra time, subsequent usage will perform even better
        if (conversionMap == null || conversionMap.Count == 0) BuildConversionMappings();

        // our return val (efficient Appends)
        var stringBuilder = new StringBuilder();

        // used for reversing the numbers
        var nums = new Stack<char>();

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

            if (char.IsDigit(character))
            {
                nums.Push(character);

                // we've reached the end of the input string OR
                // we've reached the end of the number
                if (i == text.Length - 1
                || !char.IsDigit(text[i + 1]))
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
            val = char.ToLower(val);
            conversionMap.Add(character, val);
            // add lower case version
            conversionMap.Add(char.ToLower(character), val);
        }

        // special cases
        conversionMap['y'] = ' ';
        conversionMap['Y'] = ' ';
        conversionMap.Add(' ', 'y');

        // vowels
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        for (int i = 0; i < vowels.Length; i++)
        {
            var letter = vowels[i];
            var value = (i + 1).ToString()[0];
            conversionMap[letter] = value;
            conversionMap[char.ToUpper(letter)] = value;
        }
    }
}
