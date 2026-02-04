namespace SunamoConverters._sunamo;

internal class SH
{
    #region SH.FirstCharUpper


    internal static string FirstCharUpper(string text)
    {
        if (text.Length == 1)
        {
            return text.ToUpper();
        }

        string restOfText = text.Substring(1);
        return text[0].ToString().ToUpper() + restOfText;
    }
    #endregion




    internal static string FirstCharLower(string text)
    {
        if (text.Length < 2) return text;
        var restOfText = text.Substring(1);
        return text[0].ToString().ToLower() + restOfText;
    }


}