using System.Text;

namespace UtilityClasses
{
    public class Stripper
    {
        public static string RemoveDiacritics(string accentedStr)
        {
            if (string.IsNullOrEmpty(accentedStr))
            {
                return accentedStr;                 
            }

            byte[] tempBytes;
            tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(accentedStr);
            string asciiStr = Encoding.UTF8.GetString(tempBytes);

            return asciiStr; 
        }
    }
}
