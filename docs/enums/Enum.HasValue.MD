 Verifica se um valor específico existe em um enum.

```csharp
bool HasValue()
```

## Extends:
enum.

## Exemplos de Utilização
```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        Console.WriteLine(Status.Active.HasValue());
        Console.WriteLine(((Status)5).HasValue());
    }
}
public enum Status
{
    Active,
    Inactive
}
```

Output:
```bash
true
false
```