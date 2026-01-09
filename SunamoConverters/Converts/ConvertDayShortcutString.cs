// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts between day shortcuts (Mon, Tue, etc.) and numeric representations.
/// </summary>
public class ConvertDayShortcutString
{
    /// <summary>
    /// Converts a day shortcut (Mon, Tue, etc.) to its numeric representation (0-6).
    /// </summary>
    /// <param name="text">The day shortcut string.</param>
    /// <returns>The day number (0-6), or throws an exception if the shortcut is invalid.</returns>
    public static int ToNumber(string text)
    {
        var stringBuilder = new StringBuilder(text.ToLower());
        stringBuilder[0] = char.ToUpper(stringBuilder[0]);

        var foundIndex = DTConstants.DaysInWeekENShortcut.IndexOf(stringBuilder.ToString());
        if (foundIndex != -1)
        {
            return foundIndex;
        }
        ThrowEx.IsNotAllowed(text);
        return -1;
    }

    /// <summary>
    /// Converts a day number (0-6) to its English shortcut (Mon, Tue, etc.).
    /// </summary>
    /// <param name="day">The day number (0 = Monday, 6 = Sunday).</param>
    /// <returns>The day shortcut string, or throws an exception for invalid numbers.</returns>
    public static string ToString(int day)
    {
        switch (day)
        {
            case 0:
                return "Mon";
            case 1:
                return "Tue";
            case 2:
                return "Wed";
            case 3:
                return "Thu";
            case 4:
                return "Fri";
            case 5:
                return "Sat";
            case 6:
                return "Sun";
            default:
                ThrowEx.NotImplementedCase(day);
                return null!; // ThrowEx.NotImplementedCase always throws, this is unreachable
        }
    }
}