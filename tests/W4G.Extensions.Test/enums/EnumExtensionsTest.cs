using System.ComponentModel;

namespace W4G.Extensions.Test.enums
{
    [TestClass]
    public class EnumExtensionsTest
    {
        [TestMethod]
        [DisplayName("Testa a extensão GetDescription() em diferentes valores do enum EnumTeste, incluindo cenários sem descrição.")]
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
        [DisplayName("Testa se um valor do enum EnumTeste é válido.")]
        public void IsValidEnum()
        {
            var isValid = EnumTeste.Cat.IsValidEnum<EnumTeste>();
            var isValidEnumTrue = EnumTeste.Cat.IsValidEnum<EnumTeste>(false);
            var isValidEnumFalse = EnumTeste.Undefined.IsValidEnum<EnumTeste>(false);

            Assert.IsTrue(isValid);
            Assert.IsTrue(isValidEnumTrue);
            Assert.IsFalse(isValidEnumFalse);
        }

        [TestMethod]
        [DisplayName("Teste de verificação se um valor específico existe em um enum.")]
        public void HasValue()
        {
            Status status = Status.Active;

            Assert.IsFalse(((Status)5).HasValue());
            Assert.IsTrue(status.HasValue());
        }

        [TestMethod]
        [DisplayName("Teste de Converter um enum em uma lista de seus valores.")]
        public void GetValues()
        {
            List<Status> statusList = EnumExtensions.ToList<Status>();

            Assert.IsTrue(statusList.Any());
        }
    }
}