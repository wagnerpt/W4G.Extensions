Retorna o número de CNPJ com a máscara aplica.
Em caso de CNPJ inválido, retorna Exception.

```csharp
string CnpjFormat()
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
        var value = "89539598000103";
        Console.WriteLine(value.CnpjFormat());
    }
}
```

Output:
```bash
89.539.598/0001-03
```