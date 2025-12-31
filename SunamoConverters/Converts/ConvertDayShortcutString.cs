namespace SunamoConverters.Converts;

public class ConvertDayShortcutString
{
    public static int ToNumber(string text)
    {
        var stringBuilder = new StringBuilder(text.ToLower());
        stringBuilder[0] = char.ToUpper(stringBuilder[0]);

        var dx = DTConstants.DaysInWeekENShortcut.IndexOf(stringBuilder.ToString());
        if (dx != -1)
        {
            return dx;
        }
        ThrowEx.IsNotAllowed(text);
        return -1;
    }

    public static string ToString(int day)
    {
        switch (day)
        {
            case 0:
                return "Jan";
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
                break;
        }
        return null;
    }
}