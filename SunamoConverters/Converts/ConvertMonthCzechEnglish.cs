// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts month names between Czech and English.
/// </summary>
public class ConvertMonthCzechEnglish //: IConvertCzechEnglish
{
    /// <summary>
    /// Converts an English month name to Czech.
    /// </summary>
    /// <param name="english">The English month name.</param>
    /// <returns>The Czech month name, or null if not found.</returns>
    public static string? ToCzech(string english)
    {
        switch (english)
        {
            case "January":
                return "Leden";
            case "February":
                return "\u00DAnor";
            case "March":
                return "B\u0159ezen";
            case "April":
                return "Duben";
            case "May":
                return "Kv\u011Bten";
            case "June":
                return "\u010Cerven";
            case "July":
                return "\u010Cervenec";
            case "August":
                return "Srpen";
            case "September":
                return "Z\u00E1\u0159\u00ED";
            case "October":
                return "\u0158\u00EDjen";
            case "November":
                return "Listopad";
            case "December":
                return "Prosinec";
            default:
                break;
        }
        return null;
    }

    /// <summary>
    /// Converts a Czech month name to English.
    /// </summary>
    /// <param name="czech">The Czech month name.</param>
    /// <returns>The English month name, or null if not found.</returns>
    public static string? ToEnglish(string czech)
    {
        switch (czech)
        {
            case "Leden":
                return "January";
            case "\u00DAnor":
                return "February";
            case "B\u0159ezen":
                return "March";
            case "Duben":
                return "April";
            case "Kv\u011Bten":
                return "May";
            case "\u010Cerven":
                return "June";
            case "\u010Cervenec":
                return "July";
            case "Srpen":
                return "August";
            case "Z\u00E1\u0159\u00ED":
                return "September";
            case "\u0158\u00EDjen":
                return "October";
            case "Listopad":
                return "November";
            case "Prosinec":
                return "December";
        }
        return null;
    }
}