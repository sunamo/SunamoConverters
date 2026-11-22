namespace SunamoConverters.Converts;

/// <summary>
/// Represents the rot 13 type.
/// </summary>
public static class Rot13
{
    /// <summary>
    /// Transform.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The transform result.</returns>
    public static string Transform(string value)
    {
        char[] array = value.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            int number = array[i];

            if (number >= 'a' && number <= 'z')
            {
                if (number > 'm')
                {
                    number -= 13;
                }
                else
                {
                    number += 13;
                }
            }
            else if (number >= 'A' && number <= 'Z')
            {
                if (number > 'M')
                {
                    number -= 13;
                }
                else
                {
                    number += 13;
                }
            }
            array[i] = (char)number;
        }
        return new string(array);
    }
}
