using System.Globalization;
using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class ToCurrencyTest
    {
        public ToCurrencyTest()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        }

        [TestMethod]
        public void ToCurrencyInt()
        {
            Assert.AreEqual("R$ 12.345,00", 12345.ToCurrency());
            Assert.AreEqual("R$ 12.345,000", 12345.ToCurrency(3));
            Assert.AreEqual("$12,345.00", 12345.ToCurrency(cultureName: "en-US"));

            Assert.AreEqual("-R$ 12.345,00", (-12345).ToCurrency());
            Assert.AreEqual("-R$ 12.345,000", (-12345).ToCurrency(3));
            Assert.AreEqual("-$12,345.00", (-12345).ToCurrency(cultureName: "en-US"));
        }

        [TestMethod]
        public void ToCurrencyLong()
        {
            Assert.AreEqual("R$ 12.345,00", ((long)12345).ToCurrency());
            Assert.AreEqual("R$ 12.345,000", ((long)12345).ToCurrency(3));
            Assert.AreEqual("$12,345.00", ((long)12345).ToCurrency(cultureName: "en-US"));

            Assert.AreEqual("-R$ 12.345,00", ((long)-12345).ToCurrency());
            Assert.AreEqual("-R$ 12.345,000", ((long)-12345).ToCurrency(3));
            Assert.AreEqual("-$12,345.00", ((long)-12345).ToCurrency(cultureName: "en-US"));
        }

        [TestMethod]
        public void ToCurrencyDouble()
        {
            Assert.AreEqual("R$ 12.345,68", 12345.6789.ToCurrency());
            Assert.AreEqual("R$ 12.345,67", 12345.6789.ToCurrency(truncValue: true));
            Assert.AreEqual("R$ 12.346", 12345.6789.ToCurrency(0));
            Assert.AreEqual("R$ 12.345,679", 12345.6789.ToCurrency(3));
            Assert.AreEqual("R$ 12.345,678", 12345.6789.ToCurrency(3, true));
            Assert.AreEqual("$12,345.68", 12345.6789.ToCurrency(cultureName: "en-US"));

            Assert.AreEqual("-R$ 12.345,68", (-12345.6789).ToCurrency());
            Assert.AreEqual("-R$ 12.345,67", (-12345.6789).ToCurrency(truncValue: true));
            Assert.AreEqual("-R$ 12.346", (-12345.6789).ToCurrency(0));
            Assert.AreEqual("-R$ 12.345,679", (-12345.6789).ToCurrency(3));
            Assert.AreEqual("-R$ 12.345,678", (-12345.6789).ToCurrency(3, true));
            Assert.AreEqual("-$12,345.68", (-12345.6789).ToCurrency(cultureName: "en-US"));
        }

        [TestMethod]
        public void ToCurrencyDecimal()
        {
            Assert.AreEqual("R$ 12.345,68", 12345.6789m.ToCurrency());
            Assert.AreEqual("R$ 12.345,67", 12345.6789m.ToCurrency(truncValue: true));
            Assert.AreEqual("R$ 12.346", 12345.6789m.ToCurrency(0));
            Assert.AreEqual("R$ 12.345,679", 12345.6789m.ToCurrency(3));
            Assert.AreEqual("R$ 12.345,678", 12345.6789m.ToCurrency(3, true));
            Assert.AreEqual("$12,345.68", 12345.6789m.ToCurrency(cultureName: "en-US"));

            Assert.AreEqual("-R$ 12.345,68", (-12345.6789m).ToCurrency());
            Assert.AreEqual("-R$ 12.345,67", (-12345.6789m).ToCurrency(truncValue: true));
            Assert.AreEqual("-R$ 12.346", (-12345.6789m).ToCurrency(0));
            Assert.AreEqual("-R$ 12.345,679", (-12345.6789m).ToCurrency(3));
            Assert.AreEqual("-R$ 12.345,678", (-12345.6789m).ToCurrency(3, true));
            Assert.AreEqual("-$12,345.68", (-12345.6789m).ToCurrency(cultureName: "en-US"));
        }
    }
}