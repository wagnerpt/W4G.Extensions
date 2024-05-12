Devolve o objeto serializado em uma string no formato XML.

```csharp
string ToXml()
```

## Extends
Todos objetos.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var value = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        Console.WriteLine(value.ToXml());
    }
}
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
```

Output:
```xml
<?xml version="1.0" encoding="utf-16"?>
<Pessoa xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Nome>João</Nome>
  <Sobrenome>Silva</Sobrenome>
  <Endereco>
    <Rua>Rua Um</Rua>
    <Numero>2</Numero>
    <Cep>00001-001</Cep>
  </Endereco>
</Pessoa>
```