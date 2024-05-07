using W4G.Extensions;

namespace W4G.Test;

[TestClass]
public class ToXmlTest
{
    [TestMethod]
    public void ToXmlPrimitivesObjects()
    {
        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><string>teste de string</string>", "teste de string".ToXml().Replace("\r\n", ""));
        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><char>99</char>", 'c'.ToXml().Replace("\r\n", ""));
        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><int>123</int>", 123.ToXml().Replace("\r\n", ""));
        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><double>56.89</double>", 56.89.ToXml().Replace("\r\n", ""));
    }

    [TestMethod]
    public void ToXmlObjects()
    {

        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<PessoaNome xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Nome>João da Silva</Nome>\r\n</PessoaNome>",
            new PessoaNome { Nome = "João da Silva" }.ToXml());

        var ret = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } }.ToXml();

        Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?><Pessoa xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Nome>João</Nome>  <Sobrenome>Silva</Sobrenome>  <Endereco>    <Rua>Rua Um</Rua>    <Numero>2</Numero>    <Cep>00001-001</Cep>  </Endereco></Pessoa>",
           ret.Replace("\r\n", "").Replace("\r", "").Replace("\n", ""));
    }
}
public class PessoaNome { public string Nome { get; set; } }
public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Endereco Endereco { get; set; }
}
public class Endereco
{
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Cep { get; set; }
}