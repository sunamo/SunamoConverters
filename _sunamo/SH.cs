﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SH
{
    #region SH.FirstCharUpper
    public static void FirstCharUpper(ref string nazevPP)
    {
        nazevPP = FirstCharUpper(nazevPP);
    }


    public static string FirstCharUpper(string nazevPP)
    {
        if (nazevPP.Length == 1)
        {
            return nazevPP.ToUpper();
        }

        string sb = nazevPP.Substring(1);
        return nazevPP[0].ToString().ToUpper() + sb;
    }
    #endregion
}
