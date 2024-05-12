Converte um enum em uma lista de seus valores.

```csharp
 List<TEnum> ToList()
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
        List<EnumTeste> statusList = EnumExtensions.ToList<EnumTeste>();

        foreach (var item in statusList)
            Console.WriteLine(item.Description());
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
Indefinido
Gato
Elefant
```