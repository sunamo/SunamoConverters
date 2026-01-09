// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts between month numbers (1-12) and English month shortcuts (Jan, Feb, etc.).
/// </summary>
public class ConvertMonthShortcutNumber
{
    /// <summary>
    /// Converts a month number to its English shortcut.
    /// </summary>
    /// <param name="number">The month number (1-12).</param>
    /// <returns>The month shortcut (e.g., "Jan", "Feb"), or null if the number is invalid.</returns>
    public static string? ToShortcut(int number)
    {
        var fullName = ConvertMonthNumberStringNotTranslateAble.ToString(number);
        return fullName == null ? null : ConvertMonthShortcutFullNameNotTranslateAble.ToShortcut(fullName);
    }

    /// <summary>
    /// Converts an English month shortcut to its numeric representation.
    /// </summary>
    /// <param name="shortcut">The month shortcut (e.g., "Jan", "Feb").</param>
    /// <returns>The month number (1-12).</returns>
    /// <exception cref="Exception">Thrown when the shortcut is invalid or cannot be converted.</exception>
    public static int FromShortcut(string shortcut)
    {
        var fullName = ConvertMonthShortcutFullNameNotTranslateAble.FromShortcut(shortcut);
        return ConvertMonthNumberStringNotTranslateAble.ToNumber(fullName!); // FromShortcut throws if invalid, so fullName is never null here
    }
}