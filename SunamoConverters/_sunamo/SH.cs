namespace SunamoConverters._sunamo;

internal class SH
{
    #region SH.FirstCharUpper


    internal static string FirstCharUpper(string nazevPP)
    {
        if (nazevPP.Length == 1)
        {
            return nazevPP.ToUpper();
        }

        string sb = nazevPP.Substring(1);
        return nazevPP[0].ToString().ToUpper() + sb;
    }
    #endregion




    internal static string FirstCharLower(string nazevPP)
    {
        if (nazevPP.Length < 2) return nazevPP;
        var sb = nazevPP.Substring(1);
        return nazevPP[0].ToString().ToLower() + sb;
    }
                    

}