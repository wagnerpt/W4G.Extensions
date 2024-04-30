using System.Globalization;
using System.Text;

namespace W4G.Extensions
{
    public static class NoAccentsExtensions
    {
        /// <summary>
        /// Remove a acentuação de um texto
        /// </summary>
        /// <param name="text">Texto a ser removido os acentos</param>
        /// <returns>Texto sem acentos</returns>
        public static string NoAccents(this string text)
        {
            if (text == null)
                return null;

            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
    }
}
