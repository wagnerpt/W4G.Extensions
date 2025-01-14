using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace W4G.Extensions.Strings;

public static class CharacterExtensions
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

    /// <summary>
    /// Retorna somente os alfanuméricos contido em uma string
    /// </summary>
    /// <param name="value">Objeto com o valor em texto</param>
    /// <returns>Texto contendo apenas alfanuméricos</returns>
    public static string OnlyAlphanumeric(this string value)
    {
        if (value == null)
            return null;
        return Regex.Replace(value.ToString(), @"[^\w]", "");
    }
}