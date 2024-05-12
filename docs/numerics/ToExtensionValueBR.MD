Retorna o valor por extenso.

```csharp
string ToExtensionValueBR(bool popularText = true)
```

## Extends:
int, long, double e decimal.

## Parameters:
- **popularText**: Se for informado popularText = false, traz a palavra inteiro(s) ao final do texto.

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        decimal valor = 123456789.123456789m;

        Console.WriteLine("Valor informado: " + valor);
        Console.WriteLine();
        Console.WriteLine("Valor por extenso: " + valor.ToExtensionValueBR());
        Console.WriteLine();
        Console.WriteLine("Valor por extenso: " + valor.ToExtensionValueBR(false));
    }
}
```

Output:
```bash
Valor informado: 123456789,123456789

Valor por extenso: cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove vírgula cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilionésimos

Valor por extenso: cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove inteiros e cento e vinte e três milhões e quatrocentos e cinquenta e seis mil e setecentos e oitenta e nove bilionésimos
```