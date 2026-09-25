namespace SunamoConverters.Converts;

/// <summary>
/// Provides ROT13 cipher encoding/decoding methods.
/// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 positions after it in the alphabet.
/// </summary>
public static class Rot13
{
    /// <summary>
    /// Performs the ROT13 character rotation.
    /// This method is its own inverse - applying ROT13 twice returns the original text.
    /// </summary>
    /// <param name="value">The text to transform.</param>
    /// <returns>The ROT13 transformed text.</returns>
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