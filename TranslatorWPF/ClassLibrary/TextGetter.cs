namespace TranslatorWPF
{
    public static class TextGetter
    {
        /// <summary>
        /// Get text from between two stings
        /// </summary>
        /// <param name="strSource">String with text</param>
        /// <param name="strStart">Behind this text</param>
        /// <param name="strEnd">Before this text</param>
        /// <returns>String from strSource</returns>
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
