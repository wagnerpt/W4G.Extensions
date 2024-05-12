Remove a acentuação e "ç" de um texto.

```csharp
string NoAccents()
```

## Extends:
string.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var value = "áéíóúç$&aAj";
        Console.WriteLine(value.NoAccents());

        Console.WriteLine("João".NoAccents());

        Console.WriteLine("Açucar".NoAccents());
    }
}
```

Output:
```bash
aeiouc$&aAj
Joao
Acucar
```