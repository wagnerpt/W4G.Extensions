using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class OnlyNumbersTest
    {
        private void OnlyNumbers(string expected, string atual) => Assert.AreEqual(expected, atual.OnlyNumbers());

        [TestMethod]
        public void OnlyNumbers()
        {
            OnlyNumbers("123456789", "-12345.6789");
            OnlyNumbers("123456789", "123A4C5T6.7%8&9");
        }

        [TestMethod]
        public void OnlyNumbersEmpty()
        {
            OnlyNumbers("", "");    
        }

        [TestMethod]
        public void OnlyNumbersNull()
        {
            OnlyNumbers(null, null);
        }

    }
}