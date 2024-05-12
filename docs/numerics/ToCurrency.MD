Formatar valores numéricos em moeda.

```csharp
string ToCurrency([int? decimalPlaces, bool truncValue, string? cultureName])
```

## Extends:
int, long, double e decimal.

## Parameters:
- **decimalPlaces**: Informe o número de casas decimais, se não informado assume o padrão da moeda.
- **truncValue**: Informe "true" se deseja truncar o valor ou "false" se aceitar o arredondamento.
- **cultureName**: Informe o nome da cultura. Ex. pt-br, en-US. Se não informado assume o padrão conforme o CurrentUICulture.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        double valor = 12345.6789;

        Console.WriteLine("Valor Informado: " + valor);
        Console.WriteLine();
        Console.WriteLine("Valor formatado: " + valor.ToCurrency());
        Console.WriteLine("Valor formatado sem arredondamento: " + valor.ToCurrency(truncValue: true));
        Console.WriteLine("Valor formatado sem casas decimais): " + valor.ToCurrency(0));
        Console.WriteLine("Valor formatado com 3 casas decimais: " + valor.ToCurrency(3));
        Console.WriteLine("Valor formatado com 3 casas decimais e sem arredondamento: " + valor.ToCurrency(3, true));
        Console.WriteLine("Valor formatado usando a moeda (US)): " + valor.ToCurrency(cultureName: "en-US"));
    }
}
```

Output:
```bash
Valor Informado: 12345,6789

Valor formatado: R$ 12.345,68
Valor formatado sem arredondamento: R$ 12.345,67
Valor formatado sem casas decimais): R$ 12.346
Valor formatado com 3 casas decimais: R$ 12.345,679
Valor formatado com 3 casas decimais e sem arredondamento: R$ 12.345,678
Valor formatado usando a moeda (US)): $12,345.68
```