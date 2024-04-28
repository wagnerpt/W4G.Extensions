# W4G.Extensions

Este repositório contém uma coleção de extensões para facilitar o desenvolvimento em diversas plataformas. 

Atualmente em construção, o objetivo é fornecer uma biblioteca de recursos úteis e comuns para agilizar o processo de desenvolvimento.

## Recursos Disponíveis (em constante atualização)

- **ToCurrency**: 
- Extensões para trabalhar com formação de valores monetários.
- Aplica-se a: tipos int, double ou decimal.

## Como Utilizar

1. **Instalação via NuGet**: Você pode instalar as extensões via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:
1. **Instalação via NuGet**: Você pode instalar as extensões via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:

```bash	
Install-Package W4G.Extensions
```
2. **Exemplos de Utilização**:

* ToCurrency:

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

## Contribuindo
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues para relatar bugs, sugerir novas funcionalidades ou enviar pull requests com melhorias.

## Licença
Este projeto é licenciado sob a MIT License.

Este README.md fornece uma visão geral do repositório, lista os recursos disponíveis, explica como instalar e usar as extensões, e também encoraja contribuições.