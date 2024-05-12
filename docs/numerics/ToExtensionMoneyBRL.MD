Retorna o valor por extenso em reais (R$).

```csharp
string ToExtensionMoneyBRL()
```

## Extends:
int, long, double e decimal.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        double valor = 2582.64;

        Console.WriteLine("Valor informado: " + valor);
        Console.WriteLine();
        Console.WriteLine("Valor por extenso: " + valor.ToExtensionMoneyBRL());
    }
}
```

Output:
```bash
Valor informado: 2582,64

Valor por extenso: dois mil e quinhentos e oitenta e dois reais e sessenta e quatro centavos
```