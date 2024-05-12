Devolve o CNPJ informado com os dígitos corretos.

```csharp
string CnpjCorrect()
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
        var value = "89.539.598/0001-99";
        Console.WriteLine(value.CnpjCorrect());
    }
}
```

Output:
```bash
89539598000103
```