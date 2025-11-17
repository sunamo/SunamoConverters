// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoConverters.Converts;

public class ConvertOnlyLowercase
{
    /// <summary>
    /// % - HTTP Error 400. The request URL is invalid.
    /// * - potentionally dangerous
    /// </summary>
    public static char nextUpper = '$';

    /// <summary>
    /// Pokud je velké písmeno, vloží místo něj $ a malé
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string To(string text)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in text)
        {
            if (char.IsUpper(item))
            {
                stringBuilder.Append(nextUpper);
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
    /// Pokud je znak $ další bude upper
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string From(string text)
    {
        bool b = false;
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in text)
        {
            if (b)
            {
                b = false;
                stringBuilder.Append(char.ToUpper(item));
                continue;
            }

            if (item == nextUpper)
            {
                b = true;
            }
            else
            {
                stringBuilder.Append(item);
            }
        }

        return stringBuilder.ToString();
    }

    /// pre processed conversions for letters
    private static Dictionary<char, char> Convert;

    public static string encode(string stringToEncode)
    {

        // approach: pre process a mapping (dictionary) for letter conversions
        // use a Dict for fastest look ups.  The first run, will take a little
        // extra time, subsequent usage will perform even better
        if (Convert == null || Convert.Count == 0) BuildConversionMappings();

        // our return val (efficient Appends)
        StringBuilder stringBuilder = new StringBuilder();

        // used for reversing the numbers
        Stack<char> nums = new Stack<char>();

        // iterate the input string
        for (int i = 0; i < stringToEncode.Length; i++)
        {

            char character = stringToEncode[i];

            // we have 3 cases:
            // 1) is alpha ==> convert using mapping
            // 2) is number ==> peek ahead to complete the number
            // 3) is special char / punctunation ==> ignore

            if (Convert.ContainsKey(character))
            {
                stringBuilder.Append(Convert[character]);
                continue;
            }

            if (Char.IsDigit(character))
            {
                nums.Push(character);

                // we've reached the end of the input string OR
                // we've reached the end of the number
                if (i == stringToEncode.Length - 1
                || !Char.IsDigit(stringToEncode[i + 1]))
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

        Convert = new Dictionary<char, char>();

        // only loop once for both
        for (char character = 'B'; character <= 'Z'; character++)
        {
            // add capitals version
            char val = (char)(character - 1);
            val = Char.ToLower(val);
            Convert.Add(character, val);
            // add lower case version
            Convert.Add(Char.ToLower(character), val);
        }

        // special cases
        Convert['y'] = ' ';
        Convert['Y'] = ' ';
        Convert.Add(' ', 'y');

        // vowels
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < vowels.Length; i++)
        {
            var letter = vowels[i];
            var value = (i + 1).ToString()[0];
            Convert[letter] = value;
            Convert[Char.ToUpper(letter)] = value;
        }
    }
}
