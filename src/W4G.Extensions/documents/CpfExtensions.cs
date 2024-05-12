using System.Text.RegularExpressions;

namespace W4G.Extensions.documents;

public static class CpfExtensions
{
    #region private
    private static int CalcDigits(this string CPF)
    {
        var cpf = CPF.OnlyNumbers().PadLeft(11, '0');

        if (cpf.Length > 11)
            throw new ArgumentException("CPF deve conter 11 dígitos");

        int soma = 0;

        //Calcula o primeiro dígito verificador
        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        int resto = soma % 11;
        int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

        soma = 0;

        //Calcula o segundo dígito verificador
        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        resto = soma % 11;
        int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

        return digitoVerificador1 * 10 + digitoVerificador2;
    }
    #endregion

    public static string CpfFormat(this string CPF)
    {
        if (!CpfIsValid(CPF))
            throw new ArgumentException("CPF Inválido");

        return Regex.Replace(CPF, @"(\d{3})(\d{3})(\d{3})(\d{2})", @"$1.$2.$3-$4");
    }

    public static bool CpfIsValid(this string CPF)
    {
        var cpf = CPF.Replace(".", "").Replace("-", "").PadLeft(11, '0');
        var cpfNumbers = CPF.OnlyNumbers().PadLeft(11, '0');

        if (cpf.Length > 11 || cpf != cpfNumbers)
            return false;

        return cpf == cpf.CpfCorrect();
    }

    public static string CpfCorrect(this string CPF)
    {
        var cpf = CPF.OnlyNumbers().PadLeft(11, '0');
        if (cpf.Length > 11)
            throw new ArgumentException("CPF deve conter 11 dígitos");
        return $"{cpf.Substring(0, 9)}{CalcDigits(cpf).ToString("00")}";
    }
}
