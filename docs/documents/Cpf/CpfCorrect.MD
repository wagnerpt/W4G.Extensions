Devolve o CPF informado com os dígitos corretos.

```csharp
string CpfCorrect()
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
        var value = "704.676.250-99";
        Console.WriteLine(value.CpfCorrect());
    }
}
```

Output:
```bash
70467625034
```