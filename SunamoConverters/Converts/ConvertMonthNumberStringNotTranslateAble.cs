// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Converts between English month names and numeric representations (1-12).
/// </summary>
public class ConvertMonthNumberStringNotTranslateAble //: IConvertNumberString
{
    /// <summary>
    /// Converts a full English month name to its numeric representation (1-12).
    /// </summary>
    /// <param name="text">The full English name of the month (e.g., "January").</param>
    /// <returns>The numeric representation of the month (1-12).</returns>
    /// <exception cref="Exception">Thrown when the month name is not recognized.</exception>
    public static int ToNumber(string text)
    {
        switch (text)
        {
            case "January":
                return 1;
            case "February":
                return 2;
            case "March":
                return 3;
            case "April":
                return 4;
            case "May":
                return 5;
            case "June":
                return 6;
            case "July":
                return 7;
            case "August":
                return 8;
            case "September":
                return 9;
            case "October":
                return 10;
            case "November":
                return 11;
            case "December":
                return 12;
        }
        throw new Exception($"Invalid English month name '{text}' in ConvertMonthNumberString.ToNumber()");
    }

    /// <summary>
    /// Converts a month number (1-12) to its full English name.
    /// </summary>
    /// <param name="number">The month number (1-12).</param>
    /// <returns>The full English name of the month, or null if the number is invalid.</returns>
    public static string? ToString(int number)
    {
        switch (number)
        {
            case 1:
                return "January";
            case 2:
                return "February";
            case 3:
                return "March";
            case 4:
                return "April";
            case 5:
                return "May";
            case 6:
                return "June";
            case 7:
                return "July";
            case 8:
                return "August";
            case 9:
                return "September";
            case 10:
                return "October";
            case 11:
                return "November";
            case 12:
                return "December";

            default:
                break;
        }
        return null;
    }
}