namespace SunamoConverters.Converts;

/// <summary>
/// Converts between English month shortcuts (Jan, Feb, etc.) and full month names.
/// </summary>
public static class ConvertMonthShortcutFullNameNotTranslateAble //: IConvertShortcutFullName
{
    /// <summary>
    /// Converts a month shortcut to its full English name.
    /// </summary>
    /// <param name="shortcut">The three-letter month shortcut (e.g., "Jan", "Feb").</param>
    /// <returns>The full English month name (e.g., "January", "February"), or null if invalid.</returns>
    public static string? FromShortcut(string shortcut)
    {
        switch (shortcut)
        {
            case "Jan":
                return "January";
            case "Feb":
                return "February";
            case "Mar":
                return "March";
            case "Apr":
                return "April";
            case "May":
                return "May";
            case "Jun":
                return "June";
            case "Jul":
                return "July";
            case "Aug":
                return "August";
            case "Sep":
                return "September";
            case "Oct":
                return "October";
            case "Nov":
                return "November";
            case "Dec":
                return "December";
            default:
                ThrowEx.NotImplementedCase(shortcut);
                return null!; // ThrowEx.NotImplementedCase always throws, this is unreachable
        }
    }

    /// <summary>
    /// Converts a full English month name to its three-letter shortcut.
    /// </summary>
    /// <param name="fullName">The full English month name (e.g., "January", "February").</param>
    /// <returns>The three-letter month shortcut (e.g., "Jan", "Feb"), or null if the full name is invalid.</returns>
    public static string? ToShortcut(string fullName)
    {
        switch (fullName)
        {
            case "January":
                return "Jan";
            case "February":
                return "Feb";
            case "March":
                return "Mar";
            case "April":
                return "Apr";
            case "May":
                return "May";
            case "June":
                return "Jun";
            case "July":
                return "Jul";
            case "August":
                return "Aug";
            case "September":
                return "Sep";
            case "October":
                return "Oct";
            case "November":
                return "Nov";
            case "December":
                return "Dec";
            default:
                break;
        }
        return null;
    }
}