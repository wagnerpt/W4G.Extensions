Retorna o número de CPF com a máscara aplica.
Em caso de CPF inválido, retorna Exception.

```csharp
string CpfFormat()
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
        var value = "70467625034";
        Console.WriteLine(value.CpfFormat());
    }
}
```

Output:
```bash
704.676.250-34
```