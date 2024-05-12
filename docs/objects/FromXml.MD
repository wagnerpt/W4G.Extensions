Desserializa um XML em um objeto do tipo especificado.

```csharp
T FromXml<T>()
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
        var xml = xml = "<Pessoa><Nome>João</Nome><Sobrenome>Silva</Sobrenome><Endereco><Rua>Rua Um</Rua><Numero>2</Numero><Cep>00001-001</Cep></Endereco></Pessoa>";
        Pessoa pessoa = xml.FromXml<Pessoa>();
        Console.WriteLine(pessoa.Endereco.Rua);
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
```
Rua Um
```