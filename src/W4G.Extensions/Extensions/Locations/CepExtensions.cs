using W4G.Extensions.Interfaces;
using W4G.Extensions.Models;
using W4G.Extensions.Services;
using W4G.Extensions.Strings;

namespace W4G.Extensions.Locations;

public static class CepExtensions
{
    private static readonly ICepService viaCepService = new ViaCepService();

    public static bool CepIsValid(this string cep)
    {
        string cepOnlyNumbers = cep.Replace(".", "").Replace("-", "");
        if (cepOnlyNumbers.Length != 8 || cepOnlyNumbers != cepOnlyNumbers.OnlyNumbers())
            return false;
        return viaCepService.Validate(cepOnlyNumbers);
    }

    public static Endereco CepInfo(this string cep)
    {
        string cepOnlyNumbers = cep.Replace(".", "").Replace("-", "");
        if (cepOnlyNumbers.Length != 8 || cepOnlyNumbers != cepOnlyNumbers.OnlyNumbers())
            return null;
        return viaCepService.Info(cepOnlyNumbers);
    }
    public static string CepFormat(this string cep)
    {
        string cepOnlyNumbers = cep.Replace(".", "").Replace("-", "");
        if (cepOnlyNumbers.Length != 8 || cepOnlyNumbers != cepOnlyNumbers.OnlyNumbers())
            return string.Empty;
        return cepOnlyNumbers.OnlyNumbers().Insert(5, "-");
    }

}