 Verifica se o enum especificado é um membro válido do Enum.

```csharp
bool IsValid([bool acceptUndefined = true, string undefinedEnumName = "Undefined"])
```

## Extends:
enum.

## Parameters:
- **acceptUndefined**: Se indefinido é aceito como um Enum válido. Se não informado por padrão é `true`.
- **undefinedEnumName**: Descrição do valor do enum indefinido. Se não informado por padrão é `Undefined`

## Exemplos de Utilização

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        Console.WriteLine(EnumTeste.Cat.IsValid<EnumTeste>());
        Console.WriteLine(EnumTeste.Cat.IsValid<EnumTeste>(false));
        Console.WriteLine(EnumTeste.Undefined.IsValid<EnumTeste>(false));
    }
}
public enum EnumTeste
{
    [System.ComponentModel.Description("Indefinido")]
    Undefined = 0,

    [System.ComponentModel.Description("Gato")]
    Cat = 1,

    Elefant = 2
}

```

Output:
```bash
true
true
false
```