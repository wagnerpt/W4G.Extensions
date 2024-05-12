using W4G.Extensions;

namespace W4G.Test;

[TestClass]
public class AreEqualsTest
{
    [TestMethod]
    public void AreEquals()
    {
        var obj1 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        var obj2 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        var obj3 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Dois", Numero = "23", Cep = "00001-002" } };
        var obj4 = new Pessoa() { Nome = "JoSé", Sobrenome = "Santos", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        Assert.IsTrue(obj1.AreEquals(obj2));
        Assert.IsFalse(obj1.AreEquals(obj3));
        Assert.IsFalse(obj1.AreEquals(obj4));
    }
}
