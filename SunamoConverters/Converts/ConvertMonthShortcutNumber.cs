// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoConverters.Converts;

public class ConvertMonthShortcutNumber
{
    public static string ToShortcut(int number)
    {
        var fullName = ConvertMonthNumberStringNotTranslateAble.ToString(number);
        return ConvertMonthShortcutFullNameNotTranslateAble.ToShortcut(fullName);
    }

    public static int FromShortcut(string shortcut)
    {
        var fullName = ConvertMonthShortcutFullNameNotTranslateAble.FromShortcut(shortcut);
        return ConvertMonthNumberStringNotTranslateAble.ToNumber(fullName);
    }
}
