// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Provides methods for ROT21 character substitution cipher encoding and decoding.
/// </summary>
public static class ConvertRot21
{
    /// <summary>
    /// Mapping of characters for ROT21 encoding/decoding.
    /// Key contains all characters that can occur in the input.
    /// Value contains the same characters, but swapped for encoding.
    /// </summary>
    private static List<ABT<char, char>> alphabet = new List<ABT<char, char>>();


    static ConvertRot21()
    {
        alphabet.Add(new ABT<char, char>('1', 'F'));
        alphabet.Add(new ABT<char, char>('2', 'c'));
        alphabet.Add(new ABT<char, char>('3', 'G'));
        alphabet.Add(new ABT<char, char>('4', 'D'));
        alphabet.Add(new ABT<char, char>('5', 'J'));
        alphabet.Add(new ABT<char, char>('6', 'w'));
        alphabet.Add(new ABT<char, char>('7', 'L'));
        alphabet.Add(new ABT<char, char>('8', 'Y'));
        alphabet.Add(new ABT<char, char>('9', 'W'));
        alphabet.Add(new ABT<char, char>('0', 'C'));
        alphabet.Add(new ABT<char, char>('a', 'Q'));
        alphabet.Add(new ABT<char, char>('b', 't'));
        alphabet.Add(new ABT<char, char>('c', 'd'));
        alphabet.Add(new ABT<char, char>('d', 'i'));
        alphabet.Add(new ABT<char, char>('e', '0'));
        alphabet.Add(new ABT<char, char>('f', '*'));
        alphabet.Add(new ABT<char, char>('g', 'T'));
        alphabet.Add(new ABT<char, char>('h', 'h'));
        alphabet.Add(new ABT<char, char>('i', '2'));
        alphabet.Add(new ABT<char, char>('j', '7'));
        alphabet.Add(new ABT<char, char>('k', 'n'));
        alphabet.Add(new ABT<char, char>('l', 'l'));
        alphabet.Add(new ABT<char, char>('m', 'p'));
        alphabet.Add(new ABT<char, char>('n', '~'));
        alphabet.Add(new ABT<char, char>('o', 'u'));
        alphabet.Add(new ABT<char, char>('p', 'g'));
        alphabet.Add(new ABT<char, char>('q', 'M'));
        alphabet.Add(new ABT<char, char>('r', 'S'));
        alphabet.Add(new ABT<char, char>('s', 'K'));
        alphabet.Add(new ABT<char, char>('t', '8'));
        alphabet.Add(new ABT<char, char>('u', 'O'));
        alphabet.Add(new ABT<char, char>('v', 'v'));
        alphabet.Add(new ABT<char, char>('w', '6'));
        alphabet.Add(new ABT<char, char>('x', 'x'));
        alphabet.Add(new ABT<char, char>('y', 'B'));
        alphabet.Add(new ABT<char, char>('z', 'm'));
        alphabet.Add(new ABT<char, char>('A', 'E'));
        alphabet.Add(new ABT<char, char>('B', 'Z'));
        alphabet.Add(new ABT<char, char>('C', 'f'));
        alphabet.Add(new ABT<char, char>('D', 'V'));
        alphabet.Add(new ABT<char, char>('E', 'a'));
        alphabet.Add(new ABT<char, char>('F', 'H'));
        alphabet.Add(new ABT<char, char>('G', '^'));
        alphabet.Add(new ABT<char, char>('H', '!'));
        alphabet.Add(new ABT<char, char>('I', '&'));
        alphabet.Add(new ABT<char, char>('J', '5'));
        alphabet.Add(new ABT<char, char>('K', '$'));
        alphabet.Add(new ABT<char, char>('L', 'N'));
        alphabet.Add(new ABT<char, char>('M', '@'));
        alphabet.Add(new ABT<char, char>('N', 's'));
        alphabet.Add(new ABT<char, char>('O', 'e'));
        alphabet.Add(new ABT<char, char>('P', 'P'));
        alphabet.Add(new ABT<char, char>('Q', 'j'));
        alphabet.Add(new ABT<char, char>('R', '9'));
        alphabet.Add(new ABT<char, char>('S', '#'));
        alphabet.Add(new ABT<char, char>('T', 'z'));
        alphabet.Add(new ABT<char, char>('U', 'U'));
        alphabet.Add(new ABT<char, char>('V', 'I'));
        alphabet.Add(new ABT<char, char>('W', 'r'));
        alphabet.Add(new ABT<char, char>('X', '4'));
        alphabet.Add(new ABT<char, char>('Y', 'k'));
        alphabet.Add(new ABT<char, char>('Z', 'y'));
        alphabet.Add(new ABT<char, char>('!', 'X'));
        alphabet.Add(new ABT<char, char>('@', 'q'));
        alphabet.Add(new ABT<char, char>('#', '%'));
        alphabet.Add(new ABT<char, char>('$', '1'));
        alphabet.Add(new ABT<char, char>('%', '?'));
        alphabet.Add(new ABT<char, char>('^', 'b'));
        alphabet.Add(new ABT<char, char>('&', 'o'));
        alphabet.Add(new ABT<char, char>('*', '_'));
        alphabet.Add(new ABT<char, char>('?', 'R'));
        alphabet.Add(new ABT<char, char>('_', '3'));
        alphabet.Add(new ABT<char, char>('~', 'A'));
    }

    /// <summary>
    /// Decodes a ROT21-encoded string.
    /// </summary>
    /// <param name="text">The encoded text.</param>
    /// <returns>The decoded text.</returns>
    public static string From(string text)
    {
        StringBuilder stringBuilder = new StringBuilder(text.Length);
        foreach (char item in text)
        {
            foreach (var mapping in alphabet)
            {
                if (mapping.B == item)
                {
                    stringBuilder.Append(mapping.A);
                }
            }
        }
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Encodes a string using ROT21 encoding.
    /// </summary>
    /// <param name="text">The text to encode.</param>
    /// <returns>The encoded text.</returns>
    public static string To(string text)
    {
        StringBuilder stringBuilder = new StringBuilder(text.Length);
        foreach (char item in text)
        {
            foreach (var mapping in alphabet)
            {
                if (mapping.A == item)
                {
                    stringBuilder.Append(mapping.B);
                }
            }
        }
        return stringBuilder.ToString();
    }
}