namespace W4G.Extensions.Test.enums
{
    [TestClass]
    public class EnumExtensionsTest
    {
        [TestMethod]
        public void GetDescription()
        {
            var resultEnumCat = EnumTeste.Cat.GetDescription();
            var resultEnumIndefinido = EnumTeste.Undefined.GetDescription();
            var resultDescriptionNull = EnumTeste.Elefant.GetDescription();

            Assert.AreEqual(resultEnumCat, "Gato");
            Assert.AreEqual(resultEnumIndefinido, "Indefinido");
            Assert.AreEqual(string.Empty, resultDescriptionNull);
        }

        [TestMethod]
        public void IsValidEnum()
        {
            var isValid = EnumTeste.Cat.IsValidEnum<EnumTeste>();
            var isValidEnumTrue = EnumTeste.Cat.IsValidEnum<EnumTeste>(false);
            var isValidEnumFalse = EnumTeste.Undefined.IsValidEnum<EnumTeste>(false);

            Assert.IsTrue(isValid);
            Assert.IsTrue(isValidEnumTrue);
            Assert.IsFalse(isValidEnumFalse);
        }
    }
}