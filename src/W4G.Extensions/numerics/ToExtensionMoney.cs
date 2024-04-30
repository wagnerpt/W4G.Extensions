namespace W4G.Extensions
{
    public static class ToExtensionMoneyExtensions
    {
        #region private
        private static string[] decimaisReais = { "", "", "centavo", "milésimo de real", "décimo de milésimo de real", "centésimo de milésimo de real", "milionésimo de real", "décimo de milionésimo de real", "centésimo de milionésimo de real", "bilionésimo de real", "décimo de bilionésimo de real", "centésimo de bilionésimo de real", "trilionésimo de real", "décimo de trilionésimo de real", "centésimo de trilionésimo de real", "quadrilionésimo de real", "décimo de quadrilionésimo de real", "centésimo de quadrilionésimo de real" };

        private static string CentsExtension(decimal number) => CentsExtension(number.ToString());
        private static string CentsExtension(double number) => CentsExtension(number.ToString());
        private static string CentsExtension(string number)
        {
            if (string.IsNullOrEmpty(number))
                return "";

            var stringDecimal = number.Replace(",", ".").Split(".");
            string value = stringDecimal[stringDecimal.Length - 1];
            //Tratar valores como 0.1, 0.2, 0.3 e transformar em centavos 0.10, 0.20, 0.30, etc
            if (value.Length == 1)
                value += "0";

            long decimalPartNumber = long.Parse(value);

            string part = decimalPartNumber.ToExtensionValueBR();

            if (decimalPartNumber == 0)
                part = "";
            else if (decimalPartNumber == 1)
                part += " " + decimaisReais[value.Length];
            else if (value.Length <= 2)
                part += " centavos";
            else
                part += " " + decimaisReais[value.Length].Replace("imo", "imos");
            return part;
        }
        #endregion

        /// <summary>
        /// Retorna o valor por extenso em reais
        /// </summary>
        /// <param name="number">Valor inteiro a ser formatado</param>
        /// <returns>Valor em reais por extenso</returns>
        public static string ToExtensionMoneyBRL(this int number) => ToExtensionMoneyBRL(Convert.ToInt64(number));

        /// <summary>
        /// Retorna o valor por extenso em reais
        /// </summary>
        /// <param name="number">Valor inteiro a ser formatado</param>
        /// <returns>Valor em reais por extenso</returns>
        public static string ToExtensionMoneyBRL(this long number)
        {
            var ret = number.ToExtensionValueBR();
            var absNumber = Math.Abs(number);
            if (absNumber == 1)
                return ret + " real";
            if (absNumber >= 1000000 && absNumber % 1000000 == 0)
                return ret + " de reais";
            return ret + " reais";
        }

        /// <summary>
        /// Retorna o valor por extenso em reais
        /// </summary>
        /// <param name="number">Valor inteiro a ser formatado</param>
        /// <returns>Valor em reais por extenso</returns>
        public static string ToExtensionMoneyBRL(this double number)
        {
            double parteInteira = Math.Truncate(number);
            string ret = ToExtensionMoneyBRL((long)parteInteira);
            if (parteInteira != number)
            {
                ret += " e ";
                if (parteInteira == 0)
                    ret = number < 0 ? "menos " : "";
                ret += CentsExtension(number);
            }
            return ret;
        }

        /// <summary>
        /// Retorna o valor por extenso em reais
        /// </summary>
        /// <param name="number">Valor inteiro a ser formatado</param>
        /// <returns>Valor em reais por extenso</returns>
        public static string ToExtensionMoneyBRL(this decimal number, bool popularText = true)
        {
            decimal parteInteira = Math.Truncate(number);
            string ret = ToExtensionMoneyBRL((long)parteInteira);
            if (parteInteira != number)
            {
                ret += " e ";
                if (parteInteira == 0)
                    ret = number < 0 ? "menos " : "";
                ret += CentsExtension(number);
            }
            return ret;
        }
    }
}
