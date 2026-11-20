namespace SunamoConverters.Converts;

/// <summary>
/// Represents the convert month czech english type.
/// </summary>
public class ConvertMonthCzechEnglish //: IConvertCzechEnglish
{
    /// <summary>
    /// To czech.
    /// </summary>
    /// <param name="english">The english.</param>
    /// <returns>The to czech result.</returns>
    public static string? ToCzech(string english)
    {
        switch (english)
        {
            case "January":
                return "Leden";
            case "February":
                return "Únor";
            case "March":
                return "Březen";
            case "April":
                return "Duben";
            case "May":
                return "Květen";
            case "June":
                return "Červen";
            case "July":
                return "Červenec";
            case "August":
                return "Srpen";
            case "September":
                return "Září";
            case "October":
                return "Říjen";
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
    /// To english.
    /// </summary>
    /// <param name="czech">The czech.</param>
    /// <returns>The to english result.</returns>
    public static string? ToEnglish(string czech)
    {
        switch (czech)
        {
            case "Leden":
                return "January";
            case "Únor":
                return "February";
            case "Březen":
                return "March";
            case "Duben":
                return "April";
            case "Květen":
                return "May";
            case "Červen":
                return "June";
            case "Červenec":
                return "July";
            case "Srpen":
                return "August";
            case "Září":
                return "September";
            case "Říjen":
                return "October";
            case "Listopad":
                return "November";
            case "Prosinec":
                return "December";
        }
        return null;
    }
}
