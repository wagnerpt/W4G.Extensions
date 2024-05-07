using W4G.Extensions;

namespace W4G.Test;

[TestClass]
public class ToJsonTest
{
    [TestMethod]
    public void ToJsonPrimitivesObjects()
    {
        Assert.AreEqual("\"teste de string\"", "teste de string".ToJson());
        Assert.AreEqual("\"c\"", 'c'.ToJson());
        Assert.AreEqual("123", 123.ToJson());
        Assert.AreEqual("56.89", 56.89.ToJson());
    }

    [TestMethod]
    public void ToJsonObjects()
    {
        Assert.AreEqual("{\"nome\":\"João da Silva\"}", new { nome = "João da Silva" }.ToJson());

        var ret = new { nome = "João", sobrenome = "Silva", endereco = new { rua = "Rua Um", numero = "2", cep = "00001-001" } }.ToJson();
        Assert.AreEqual("{\"nome\":\"João\",\"sobrenome\":\"Silva\",\"endereco\":{\"rua\":\"Rua Um\",\"numero\":\"2\",\"cep\":\"00001-001\"}}", ret);
    }

}