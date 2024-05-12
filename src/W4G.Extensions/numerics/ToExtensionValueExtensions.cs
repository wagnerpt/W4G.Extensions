namespace W4G.Extensions;

public static class ToExtensionValueExtensions
{
    #region private
    private static string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
    private static string[] dezAVinte = { "dez", "onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
    private static string[] dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
    private static string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
    private static string[] milhar = { "", "mil", "milhão", "bilhão", "trilhão", "quadrilhão", "quintilhão", "sextilhão", "setilhão", "octilhão", "nonilhão", "decilhão", "undecilhão", "dodecilhão", "tredicilhão", "quatordecilhão", "quindecilhão", "sedecilhão", "septendecilhão" };
    private static string[] decimais = { "", "décimo", "centésimo", "milésimo", "décimo de milésimo", "centésimo de milésimo", "milionésimo", "décimo de milionésimo", "centésimo de milionésimo", "bilionésimo", "décimo de bilionésimo", "centésimo de bilionésimo", "trilionésimo", "décimo de trilionésimo", "centésimo de trilionésimo", "quadrilionésimo", "décimo de quadrilionésimo", "centésimo de quadrilionésimo" };

    private static string partNumberExtension(long number, int milharIndex)
    {
        long partNumber = number % 1000;

        string part = string.Empty;

        if (number == 1 && milharIndex == 1)
            return "mil";
        else if (partNumber == 0)
            return "";
        else if (partNumber < 10)
            part = unidades[partNumber];
        else if (partNumber < 20)
            part = dezAVinte[partNumber - 10];
        else if (partNumber < 100)
            part = dezenas[partNumber / 10] + (partNumber % 10 != 0 ? " e " + unidades[partNumber % 10] : "");
        else
            part = centenas[partNumber / 100] + (partNumber % 100 != 0 ? " e " + partNumberExtension(partNumber % 100, 0) : "");

        part += (milharIndex > 0 ? " " + milhar[milharIndex] : "");

        if (partNumber > 1)
            part = part.Replace("ão", "ões");
        return part;
    }

    private static string partDecimalExtension(string number)
    {
        if (string.IsNullOrEmpty(number))
            return "";

        var stringDecimal = number.Replace(",", ".").Split(".");
        string value = stringDecimal[stringDecimal.Length - 1];

        long decimalPartNumber = long.Parse(value);

        string part = ToExtensionValueBR(decimalPartNumber);

        if (decimalPartNumber == 0)
            part = "";
        else if (decimalPartNumber == 1)
            part += " " + decimais[value.ToString().Length];
        else
            part += " " + decimais[value.ToString().Length].Replace("imo", "imos");
        return part;
    }

    private static string partDecimalExtension(decimal number)
    {
        return partDecimalExtension(number.ToString());

        /*
        long decimalPartNumber = Convert.ToInt64((Math.Abs(number) % 1).ToString().Substring(2));

        string part = ToExtensionValueBR(decimalPartNumber);

        if (decimalPartNumber == 0)
            part = "";
        else if (decimalPartNumber == 1)
            part += " " + decimais[decimalPartNumber.ToString().Length];
        else
            part += " " + decimais[decimalPartNumber.ToString().Length].Replace("imo", "imos");
        return part;
        */
    }

    private static string partDecimalExtension(double number)
    {
        return partDecimalExtension(number.ToString());
    }
    #endregion

    /// <summary>
    /// Retorna o valor por extenso
    /// </summary>
    /// <param name="number">Valor inteiro a ser formatado</param>
    /// <param name="popularText">Se for informado popularText = false, traz a palavra inteiro(s) ao final do texto</param>
    /// <returns>Valor por extenso</returns>
    public static string ToExtensionValueBR(this int number, bool popularText = true) => ToExtensionValueBR(Convert.ToInt64(number), popularText);

    /// <summary>
    /// Retorna o valor por extenso
    /// </summary>
    /// <param name="number">Valor long a ser formatado</param>
    /// <param name="popularText">Se for informado popularText = false, traz a palavra inteiro(s) ao final do texto</param>
    /// <returns>Valor por extenso</returns>
    public static string ToExtensionValueBR(this long number, bool popularText = true)
    {
        if (number < 0)
            return "menos " + ToExtensionValueBR(Math.Abs(number));
        if (number == 0)
            return "zero";
        if (number == 100)
            return "cem";

        string ret = "";
        for (int i = 0; i < 19; i++)
        {
            long part = number / (long)Math.Pow(1000, i);

            if (part == 0)
                break;

            ret = partNumberExtension(part, i) + (ret == "" ? "" : " e ") + ret;
        }
        if (!popularText)
            ret += number == 1 ? " inteiro" : " inteiros";

        return ret;
    }

    /// <summary>
    /// Retorna o valor por extenso
    /// </summary>
    /// <param name="number">Valor double a ser formatado</param>
    /// <param name="popularText">Se for informado popularText = false, traz a palavra inteiro(s) no texto</param>
    /// <returns>Valor por extenso</returns>
    public static string ToExtensionValueBR(this double number, bool popularText = true) 
     {
         double parteInteira = Math.Truncate(number);
         string ret = ToExtensionValueBR((long)parteInteira);
         if (parteInteira != number)
         {
             ret += popularText ? " vírgula " : (parteInteira == 1 ? " inteiro e " : " inteiros e ");
             ret += partDecimalExtension(number);
         }
         return ret;
     }

    /// <summary>
    /// Retorna o valor por extenso
    /// </summary>
    /// <param name="number">Valor decimal a ser formatado</param>
    /// <param name="popularText">Se for informado popularText = false traz a palavra inteiro(s) no texto</param>
    /// <returns>Valor por extenso</returns>
    public static string ToExtensionValueBR(this decimal number, bool popularText = true)
    {
        decimal parteInteira = Math.Truncate(number);
        string ret = ToExtensionValueBR((long)parteInteira);
        if (parteInteira != number)
        {
            ret += popularText ? " vírgula " : (parteInteira == 1 ? " inteiro e " : " inteiros e ");
            ret += partDecimalExtension(number);
        }
        return ret;
    }
}
