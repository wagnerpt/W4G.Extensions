using System.Globalization;
using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class ToExtensionValueTest
    {
        public ToExtensionValueTest()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        }

        [TestMethod]
        public void ToExtension()
        {
            long value = 0;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("zero", result);
        }

        [TestMethod]
        public void ToExtensionNegative()
        {
            long value = -1239;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos mil e duzentos e trinta e nove", result);
        }

        [TestMethod]
        public void ToExtensionPositive()
        {
            long value = 123456789;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove", result);
        }

        [TestMethod]
        public void ToExtensionHundred()
        {
            long value = 100;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cem", result);
        }

        [TestMethod]
        public void ToExtension2582()
        {
            long value = 2582;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("dois mil e quinhentos e oitenta e dois", result);
        }

        [TestMethod]
        public void ToExtensionThousand()
        {
            long value = 1000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("mil", result);
        }
        [TestMethod]
        public void ToExtensionMillion()
        {
            long value = 1000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um milhão", result);
        }

        [TestMethod]
        public void ToExtensionBillion()
        {
            long value = 1000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um bilhão", result);
        }

        [TestMethod]
        public void ToExtensionTrillion()
        {
            long value = 1000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um trilhão", result);
        }

        [TestMethod]
        public void ToExtensionQuadrillion()
        {
            long value = 1000000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um quadrilhão", result);
        }

        [TestMethod]
        public void ToExtensionQuintillion()
        {
            long value = 1000000000000000000;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um quintilhão", result);
        }

        [TestMethod]
        public void IntToExtension()
        {
            int value = 123456789;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove", result);
        }

        [TestMethod]
        public void Double()
        {
            Assert.AreEqual("zero vírgula um décimo", 0.1.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um centésimo", 0.01.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um milésimo", 0.001.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um décimo de milésimo", 0.0001.ToExtensionValueBR());
            Assert.AreEqual("um vírgula um centésimo de milésimo", 1.00001.ToExtensionValueBR());
            Assert.AreEqual("doze vírgula um milionésimo", 12.000001.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três décimos de milésimos", 0.0123.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula mil e duzentos e trinta e quatro milionésimos", 0.001234.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula doze centésimos", 0.12.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três milésimos", 0.123.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula mil e duzentos e trinta e quatro décimos de milésimos", 0.1234.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula doze mil e trezentos e quarenta e cinco centésimos de milésimos", 0.12345.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três mil e quatrocentos e cinquenta e seis milionésimos", 0.123456.ToExtensionValueBR());
        }

        [TestMethod]
        public void Decimal()
        {
            Assert.AreEqual("zero vírgula um décimo", 0.1m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um centésimo", 0.01m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um milésimo", 0.001m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula um décimo de milésimo", 0.0001m.ToExtensionValueBR());
            Assert.AreEqual("um vírgula um centésimo de milésimo", 1.00001m.ToExtensionValueBR());
            Assert.AreEqual("doze vírgula um milionésimo", 12.000001m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três décimos de milésimos", 0.0123m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula mil e duzentos e trinta e quatro milionésimos", 0.001234m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula doze centésimos", 0.12m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três milésimos", 0.123m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula mil e duzentos e trinta e quatro décimos de milésimos", 0.1234m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula doze mil e trezentos e quarenta e cinco centésimos de milésimos", 0.12345m.ToExtensionValueBR());
            Assert.AreEqual("zero vírgula cento e vinte e três mil e quatrocentos e cinquenta e seis milionésimos", 0.123456m.ToExtensionValueBR());
        }

        [TestMethod]
        public void DecimalToExtension()
        {
            decimal value = 123456789.123456789m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove vírgula cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilionésimos", result);
        }

        [TestMethod]
        public void DecimalToExtensionNoPopular()
        {
            decimal value = 123456789.123456789m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove inteiros e cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilionésimos", result);
        }

        [TestMethod]
        public void DecimalToExtensionNegative()
        {
            decimal value = -123456789.123456789m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove vírgula cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilionésimos", result);
        }

        [TestMethod]
        public void DecimalToExtensionZero()
        {
            decimal value = 0.0m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("zero", result);
        }

        [TestMethod]
        public void DecimalToExtensionOne()
        {
            decimal value = 1.0m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um", result);
        }

        [TestMethod]
        public void DecimalToExtensionOneDecimal()
        {
            decimal value = 1.1m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("um vírgula um décimo", result);
        }

        [TestMethod]
        public void DecimalToExtensionOneDecimalNegative()
        {
            decimal value = -1.1m;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("menos um vírgula um décimo", result);
        }

        [TestMethod]
        public void DoubleToExtension()
        {
            double value = 123456789.12345678;

            var result = value.ToExtensionValueBR();

            Assert.AreEqual("cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove vírgula doze milhões e trezentos e quarenta e cinco mil e seiscentos e setenta e oito centésimos de milionésimos", result);
        }

        [TestMethod]
        public void DecimalNoPopularText()
        {
            decimal value = 1.1m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("um inteiro e um décimo", result);
        }

        [TestMethod]
        public void DecimalNoPopularText2()
        {
            decimal value = 231.12m;

            var result = value.ToExtensionValueBR(false);

            Assert.AreEqual("duzentos e trinta e um inteiros e doze centésimos", result);
        }
    }
}