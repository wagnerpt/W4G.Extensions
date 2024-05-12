Retorna se o valor informado é um número de CNPJ válido.

```csharp
bool CnpjIsValid()
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
        Console.WriteLine(value.CnpjIsValid());
    }
}
```

Output:
```bash
false
```