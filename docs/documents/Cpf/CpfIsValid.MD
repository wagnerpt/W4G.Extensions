Retorna se o valor informado é um número de CPF válido.

```csharp
bool CpfIsValid()
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
        Console.WriteLine(value.CpfIsValid());
    }
}
```

Output:
```bash
false
```