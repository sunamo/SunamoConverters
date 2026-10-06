namespace SunamoConverters.Converts;

public class ConvertDayShortcutString
{
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
                return null!;
        }
    }
}
