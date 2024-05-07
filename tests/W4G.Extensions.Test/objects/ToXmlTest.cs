using W4G.Extensions;

namespace W4G.Test;

[TestClass]
public class ToXmlTest
{
    [TestMethod]
    public void XmlObjects()
    {
        var objPessoaNome = new PessoaNome { Nome = "João da Silva" };
        var xml = "<PessoaNome><Nome>João da Silva</Nome></PessoaNome>";
        Assert.AreEqual(objPessoaNome.Nome, xml.FromXml<PessoaNome>().Nome);
        Assert.AreEqual(objPessoaNome.Nome, objPessoaNome.ToXml().FromXml<PessoaNome>().Nome);

        var objPessoa = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        xml = "<Pessoa><Nome>João</Nome><Sobrenome>Silva</Sobrenome><Endereco><Rua>Rua Um</Rua><Numero>2</Numero><Cep>00001-001</Cep></Endereco></Pessoa>";
        Assert.AreEqual(objPessoa.Nome, xml.FromXml<Pessoa>().Nome);
        Assert.AreEqual(objPessoa.Nome, objPessoa.ToXml().FromXml<Pessoa>().Nome);
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