Retorna somente os números contido em uma string.

```csharp
string OnlyNumbers()
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
        var value = "123A4C5T6.7%8&9";
        Console.WriteLine(value.OnlyNumbers());
    }
}
```

Output:
```bash
123456789
```