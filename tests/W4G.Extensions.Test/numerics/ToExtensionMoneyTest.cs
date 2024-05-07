using System.Globalization;
using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class ToExtensionMoneyTest
    {
        public ToExtensionMoneyTest()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        }

        private void ToExtensionMoney(string expected, int value) => Assert.AreEqual(expected, value.ToExtensionMoneyBRL());
        private void ToExtensionMoney(string expected, long value) => Assert.AreEqual(expected, value.ToExtensionMoneyBRL());
        private void ToExtensionMoney(string expected, double value) => Assert.AreEqual(expected, value.ToExtensionMoneyBRL());
        private void ToExtensionMoney(string expected, decimal value) => Assert.AreEqual(expected, value.ToExtensionMoneyBRL());

        [TestMethod]
        public void ToExtension()
        {
            ToExtensionMoney("zero reais", 0);
            ToExtensionMoney("um real", 1);
            ToExtensionMoney("dez reais", 10);
            ToExtensionMoney("doze reais", 12);
            ToExtensionMoney("cem reais", 100);
            ToExtensionMoney("cento e vinte e três reais", 123);
            ToExtensionMoney("mil reais", 1000);
            ToExtensionMoney("um milhão de reais", 1000000);
            ToExtensionMoney("um bilhão de reais", 1000000000);
            ToExtensionMoney("um trilhão de reais", 1000000000000);
            ToExtensionMoney("dois mil e quinhentos e oitenta e dois reais", 2582);
            ToExtensionMoney("um milhão e dois mil e quinhentos e oitenta e dois reais", 1002582);
        }

        [TestMethod]
        public void ToExtensionNegative()
        {
            ToExtensionMoney("zero reais", -0);
            ToExtensionMoney("menos um real", -1);
            ToExtensionMoney("menos dez reais", -10);
            ToExtensionMoney("menos doze reais", -12);
            ToExtensionMoney("menos cem reais", -100);
            ToExtensionMoney("menos cento e vinte e três reais", -123);
            ToExtensionMoney("menos mil reais", -1000);
            ToExtensionMoney("menos um milhão de reais", -1000000);
            ToExtensionMoney("menos um bilhão de reais", -1000000000);
            ToExtensionMoney("menos um trilhão de reais", -1000000000000);
            ToExtensionMoney("menos dois mil e quinhentos e oitenta e dois reais", -2582);
            ToExtensionMoney("menos um milhão e dois mil e quinhentos e oitenta e dois reais", -1002582);
        }

        [TestMethod]
        public void ToExtensionDecimal()
        {
            ToExtensionMoney("zero reais", 0.0m);
            ToExtensionMoney("um real", 1.0m);
            ToExtensionMoney("doze reais", 12.0m);
            ToExtensionMoney("cem reais", 100.0m);
            ToExtensionMoney("dois mil e quinhentos e oitenta e dois reais", 2582.0m);
            ToExtensionMoney("um milhão e dois mil e quinhentos e oitenta e dois reais", 1002582.0m);
            ToExtensionMoney("um centavo", 0.01m);
            ToExtensionMoney("cinquenta centavos", 0.50m);
            ToExtensionMoney("trinta e um centavos", 0.31m);
            ToExtensionMoney("um real e dez centavos", 1.10m);
            ToExtensionMoney("doze reais e trinta e oito centavos", 12.38m);
            ToExtensionMoney("cem reais e vinte e cinco milésimos de real", 100.025m);
            ToExtensionMoney("dois mil e quinhentos e oitenta e dois reais e quatro mil e quinhentos e sessenta e quatro décimos de milésimos de real", 2582.4564m);
            ToExtensionMoney("um milhão e dois mil e quinhentos e oitenta e dois reais e noventa e nove centavos", 1002582.99m);
        }

        [TestMethod]
        public void ToExtensionNegativeDecimal()
        {
            ToExtensionMoney("zero reais", -0.0m);
            ToExtensionMoney("menos um real", -1.0m);
            ToExtensionMoney("menos doze reais", -12.0m);
            ToExtensionMoney("menos cem reais", -100.0m);
            ToExtensionMoney("menos dois mil e quinhentos e oitenta e dois reais", -2582.0m);
            ToExtensionMoney("menos um milhão e dois mil e quinhentos e oitenta e dois reais", -1002582.0m);
            ToExtensionMoney("menos um centavo", -0.01m);
            ToExtensionMoney("menos um real e dez centavos", -1.10m);
            ToExtensionMoney("menos doze reais e trinta e oito centavos", -12.38m);
            ToExtensionMoney("menos cem reais e vinte e cinco milésimos de real", -100.025m);
            ToExtensionMoney("menos dois mil e quinhentos e oitenta e dois reais e quatro mil e quinhentos e sessenta e quatro décimos de milésimos de real", -2582.4564m);
            ToExtensionMoney("menos um milhão e dois mil e quinhentos e oitenta e dois reais e noventa e nove centavos", -1002582.99m);
        }

        [TestMethod]
        public void ToExtensionDouble()
        {
            ToExtensionMoney("zero reais", 0.0);
            ToExtensionMoney("um real", 1.0);
            ToExtensionMoney("doze reais", 12.0);
            ToExtensionMoney("cem reais", 100.0);
            ToExtensionMoney("dois mil e quinhentos e oitenta e dois reais", 2582.0);
            ToExtensionMoney("um milhão e dois mil e quinhentos e oitenta e dois reais", 1002582.0);
            ToExtensionMoney("um centavo", 0.01);
            ToExtensionMoney("cinquenta centavos", 0.50);
            ToExtensionMoney("trinta e um centavos", 0.31);
            ToExtensionMoney("um real e dez centavos", 1.10);
            ToExtensionMoney("doze reais e trinta e oito centavos", 12.38);
            ToExtensionMoney("cem reais e vinte e cinco milésimos de real", 100.025);
            ToExtensionMoney("dois mil e quinhentos e oitenta e dois reais e quatro mil e quinhentos e sessenta e quatro décimos de milésimos de real", 2582.4564);
            ToExtensionMoney("um milhão e dois mil e quinhentos e oitenta e dois reais e noventa e nove centavos", 1002582.99);
        }

        [TestMethod]
        public void ToExtensionNegativeDouble()
        {
            ToExtensionMoney("zero reais", -0.0);
            ToExtensionMoney("menos um real", -1.0);
            ToExtensionMoney("menos doze reais", -12.0);
            ToExtensionMoney("menos cem reais", -100.0);
            ToExtensionMoney("menos dois mil e quinhentos e oitenta e dois reais", -2582.0);
            ToExtensionMoney("menos um milhão e dois mil e quinhentos e oitenta e dois reais", -1002582.0);
            ToExtensionMoney("menos um centavo", -0.01);
            ToExtensionMoney("menos um real e dez centavos", -1.10);
            ToExtensionMoney("menos doze reais e trinta e oito centavos", -12.38);
            ToExtensionMoney("menos cem reais e vinte e cinco milésimos de real", -100.025);
            ToExtensionMoney("menos dois mil e quinhentos e oitenta e dois reais e quatro mil e quinhentos e sessenta e quatro décimos de milésimos de real", -2582.4564);
            ToExtensionMoney("menos um milhão e dois mil e quinhentos e oitenta e dois reais e noventa e nove centavos", -1002582.99);
        }

    }
}