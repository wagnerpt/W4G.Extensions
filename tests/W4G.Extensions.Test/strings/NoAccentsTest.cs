using W4G.Extensions;

namespace W4G.Test
{
    [TestClass]
    public class NoAccentsTest
    {
        private void NoAccents(string expected, string atual) => Assert.AreEqual(expected, atual.NoAccents());

        [TestMethod]
        public void NoAccents()
        {
            NoAccents("aeiouc$&aAj", "áéíóúç$&aAj");
            NoAccents("Joao", "João");
            NoAccents("Acucar", "Açucar");
        }

        [TestMethod]
        public void NoAccentsEmpty()
        {
            NoAccents("", "");
        }

        [TestMethod]
        public void NoAccentsNull()
        {
            NoAccents(null, null);
        }

    }
}