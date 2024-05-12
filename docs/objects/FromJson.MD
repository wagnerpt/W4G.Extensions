Desserializa um JSON em um objeto do tipo especificado usando JsonSerializerSettings.

```csharp
T FromJson<T>()
T FromJson<T>(params JsonConverter[] converters)
T FromJson<T>(JsonSerializerSettings settings)
```

## Extends
string.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var json = "{\"Nome\":\"João\",\"Sobrenome\":\"Silva\",\"Endereco\":{\"Rua\":\"Rua Um\",\"Numero\":\"2\",\"Cep\":\"00001-001\"}}";
        var pessoa = json.FromJson<Pessoa>();
        Console.WriteLine(pessoa.Nome());
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
João
```