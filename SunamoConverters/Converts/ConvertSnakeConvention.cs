namespace SunamoConverters.Converts;

/// <summary>
/// Converts text to and from snake_case convention (words_separated_by_underscores).
/// </summary>
public class ConvertSnakeConvention
{
    /// <summary>
    /// Sanitizes the input string by removing special characters and normalizing underscores.
    /// </summary>
    /// <param name="input">The input string to sanitize.</param>
    /// <returns>The sanitized string.</returns>
    private static string Sanitize(string input)
    {
        var text = new StringBuilder(input.Replace(" ", "_").Replace("__", "_"));
        for (int i = text.Length - 1; i >= 0; i--)
        {
            var character = text[i];
            if (!char.IsLetter(character) && !char.IsDigit(character) && character != '_')
            {
                text = text.Remove(i, 1);
            }
        }
        return text.ToString();
    }

    /// <summary>
    /// Converts a string to snake_case convention.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>The string converted to snake_case.</returns>
    public static string ToConvention(string input)
    {
        var result = string.Concat(input.Select((character, index) => index > 0 && char.IsUpper(character) ? "_" + character.ToString() : character.ToString())).ToLower();
        return Sanitize(result);
    }
}