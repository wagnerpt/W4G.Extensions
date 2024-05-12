using System.Text.RegularExpressions;

namespace W4G.Extensions
{
    public static class OnlyNumbersExtensions
    {
        /// <summary>
        /// Retorna somente os números contido em uma string
        /// </summary>
        /// <param name="value">Objeto com o valor em texto</param>
        /// <returns>Texto contendo apenas números</returns>
        public static string OnlyNumbers(this string value)
        {
            if (value == null)
                return null;
            return Regex.Replace(value.ToString(), @"[^\d]", "");
        }
    }
}
