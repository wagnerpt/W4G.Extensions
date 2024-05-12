 Compara as propriedades públicas do objeto com as propriedades do outro objeto, retornando true se forem iguais e false caso contrário. 
 
 Pode ser utilizado para implementar dentro do método Equals em classes de forma genérica.

```csharp
bool AreEquals(object otherObject)
```

## Extends:
Todos objetos.

## Parameters:
- **otherObject**: O outro objeto a ser comparado.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var obj1 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        var obj2 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        var obj3 = new Pessoa() { Nome = "João", Sobrenome = "Silva", Endereco = new Endereco() { Rua = "Rua Dois", Numero = "23", Cep = "00001-002" } };
        var obj4 = new Pessoa() { Nome = "José", Sobrenome = "Santos", Endereco = new Endereco() { Rua = "Rua Um", Numero = "2", Cep = "00001-001" } };
        Console.WriteLine(obj1.AreEquals(obj2));
        Console.WriteLine(obj1.AreEquals(obj3));
        Console.WriteLine(obj1.AreEquals(obj4));
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
```bash
true
false
false
```