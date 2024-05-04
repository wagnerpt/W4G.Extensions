using System.Text.RegularExpressions;

namespace W4G.Extensions.documents;

public static class CnpjExtensions
{
    #region private
    private static int CalcDigits(string CNPJ)
    {
        var cnpj = CNPJ.OnlyNumbers().PadLeft(14, '0');

        if (cnpj.Length != 14)
            throw new ArgumentException("CNPJ deve conter 14 dígitos");

        int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int soma = 0;
        //Calcula o primeiro dígito verificador
        for (int i = 0; i < 12; i++)
            soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];
        int resto = soma % 11;
        int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

        soma = 0;
        //Calcula o segundo dígito verificador
        for (int i = 0; i < 13; i++)
            soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];
        resto = soma % 11;
        int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

        return digitoVerificador1* 10 + digitoVerificador2;
    }
    #endregion

    public static string CnpjFormat(this string CNPJ)
    {
        if (!CnpjIsValid(CNPJ))
            throw new ArgumentException("Cnpj Inválido");

        return Regex.Replace(CNPJ.OnlyNumbers(), @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})", @"$1.$2.$3/$4-$5");
    }

    public static bool CnpjIsValid(this string CNPJ)
    {
        var cnpj = CNPJ.Replace(".", "").Replace("-", "").Replace("/", "").PadLeft(14, '0');
        var cnpjNumbers = CNPJ.OnlyNumbers().PadLeft(14, '0');

        if (cnpj.Length > 14 || cnpj != cnpjNumbers)
            return false;

        return cnpj == cnpj.CnpjCorrect();
    }

    public static string CnpjCorrect(this string CNPJ)
    {
        var cnpj = CNPJ.OnlyNumbers().PadLeft(14, '0');
        if (cnpj.Length > 14)
            throw new ArgumentException("CNPJ deve conter 14 dígitos");
        return $"{cnpj.Substring(0, 12)}{CalcDigits(cnpj).ToString("00")}";
    }


}
