Pega a descrição do valor de um Enum.

```csharp
string Description()
```

## Extends:
enum.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        Console.WriteLine(EnumTeste.Cat.Description());
        Console.WriteLine(EnumTeste.Undefined.Description());
        Console.WriteLine(EnumTeste.Elefant.Description());
    }
}
public enum EnumTeste
{
    [System.ComponentModel.Description("Indefinido")]
    Undefined = 0,

    [System.ComponentModel.Description("Gato")]
    Cat = 1,

    Elefant = 2
}
```

Output:
```bash
Gato
Indefinido
Elefant
```