using System.Globalization;

namespace W4G.Extensions
{
    /// <summary>
    /// Extensão para formatar valores numéricos em moeda.
    /// Extende os tipos int, double e decimal.
    /// </summary>
    public static class ToCurrencyExtensions
    {
        /// <summary>
        /// Formata um valor inteiro em moeda.
        /// </summary>
        /// <param name="value">Valor inteiro a ser formatado</param>
        /// <param name="decimalPlaces">Informe o número de casas decimais, se não informado assume o padrão da moeda.</param>
        /// <param name="cultureName">Informe o nome da cultura. Ex. pt-br, en-US. Se não informado assume o padrão conforme o CurrentUICulture.</param>
        /// <returns>Retorna a string no formato de moeda</returns>
        public static string ToCurrency(this int value, int? decimalPlaces = null, string? cultureName = null)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureName ?? CultureInfo.CurrentUICulture.Name);
            string mask = $"C{decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits}";
            return value.ToString(mask, cultureInfo);
        }

        /// <summary>
        /// Formata um valor double em moeda.
        /// </summary>
        /// <param name="value">Valor double a ser formatado</param>
        /// <param name="decimalPlaces">Informe o número de casas decimais, se não informado assume o padrão da moeda.</param>
        /// <param name="truncValue">Informe "true" se deseja truncar o valor ou "false" se aceitar o arredondamento</param>
        /// <param name="cultureName">Informe o nome da cultura. Ex. pt-br, en-US. Se não informado assume o padrão conforme o CurrentUICulture.</param>
        /// <returns>Retorna a string no formato de moeda</returns>
        public static string ToCurrency(this double value, int? decimalPlaces = null, bool truncValue = false, string? cultureName = null)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureName ?? CultureInfo.CurrentUICulture.Name);

            //Ajusta o valor para o número de casas decimais informado e a utilização de truncamento
            double ret = value;
            if (truncValue)
                ret = double.Truncate(Math.Pow(10, decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits) * value) / Math.Pow(10, decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits);

            string mask = $"C{decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits}";
            return ret.ToString(mask, cultureInfo);
        }

        /// <summary>
        /// Formata um valor decimal em moeda.
        /// </summary>
        /// <param name="value">Valor decimal a ser formatado</param>
        /// <param name="decimalPlaces">Informe o número de casas decimais, se não informado assume o padrão da moeda.</param>
        /// <param name="truncValue">Informe "true" se deseja truncar o valor ou "false" se aceitar o arredondamento</param>
        /// <param name="cultureName">Informe o nome da cultura. Ex. pt-br, en-US. Se não informado assume o padrão conforme o CurrentUICulture.</param>
        /// <returns>Retorna a string no formato de moeda</returns>
        public static string ToCurrency(this decimal value, int? decimalPlaces = null, bool truncValue = false, string? cultureName = null)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureName ?? CultureInfo.CurrentUICulture.Name);

            //Ajusta o valor para o número de casas decimais informado e a utilização de truncamento
            decimal ret = value;
            if (truncValue)
                ret = decimal.Truncate((decimal)Math.Pow(10, decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits) * value) / (decimal)Math.Pow(10, decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits);

            string mask = $"C{decimalPlaces ?? cultureInfo.NumberFormat.CurrencyDecimalDigits}";
            return ret.ToString(mask, cultureInfo);
        }
    }
}
