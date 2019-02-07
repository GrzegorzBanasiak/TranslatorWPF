using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorWPF.ClassLibrary
{
    static class TextGetter
    {
        //Metoda wyciąga tekst z odpowiedzi XML z api 
        //pobiera tekst, 2 stringi reprezentujace poczatek i koniec pobranego tekstu
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;

            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);

                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}
