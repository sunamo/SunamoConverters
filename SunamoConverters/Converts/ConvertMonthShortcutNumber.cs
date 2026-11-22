namespace SunamoConverters.Converts;

/// <summary>
/// Represents the convert month shortcut number type.
/// </summary>
public class ConvertMonthShortcutNumber
{
    /// <summary>
    /// To shortcut.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns>The to shortcut result.</returns>
    public static string? ToShortcut(int number)
    {
        var fullName = ConvertMonthNumberStringNotTranslateAble.ToString(number);
        return fullName is null ? null : ConvertMonthShortcutFullNameNotTranslateAble.ToShortcut(fullName);
    }

    /// <summary>
    /// From shortcut.
    /// </summary>
    /// <param name="shortcut">The shortcut.</param>
    /// <returns>The from shortcut result.</returns>
    public static int FromShortcut(string shortcut)
    {
        var fullName = ConvertMonthShortcutFullNameNotTranslateAble.FromShortcut(shortcut);
        return ConvertMonthNumberStringNotTranslateAble.ToNumber(fullName!);
    }
}
