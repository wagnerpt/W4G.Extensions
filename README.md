# W4G.Extensions

![C#](https://img.shields.io/badge/.NET%206.0-00F?style=for-the-badge&logoColor=FFF&logo=DotNet) ![C#](https://img.shields.io/badge/.NET%207.0-00F?style=for-the-badge&logoColor=FFF&logo=DotNet) ![C#](https://img.shields.io/badge/.NET%208.0-00F?style=for-the-badge&logoColor=FFF&logo=DotNet)

Este repositório contém uma coleção de extensões para facilitar o desenvolvimento em diversas plataformas. 

Atualmente em construção, o objetivo é fornecer uma biblioteca de recursos úteis e comuns para agilizar o processo de desenvolvimento.

## Recursos Disponíveis (em constante atualização)


**Extensões para documentos** ([detalhes](https://github.com/wagnerpt/W4G.Extensions/wiki/Extens%C3%B5es-para-documentos))
- **CPF**: [CpfIsValid](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfIsValid), [CpfCorrect](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfCorrect), [CpfFormat](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfFormat).
- **CNPJ**: [CnpjIsValid](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjIsValid), [CnpjCorrect](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjCorrect), [CnpjFormat](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjFormat).

**Extensões para Serialização** ([detalhes](https://github.com/wagnerpt/W4G.Extensions/wiki/Extens%C3%B5es-para-Serializa%C3%A7%C3%A3o))
- **Json**: [ToJson](https://github.com/wagnerpt/W4G.Extensions/wiki/ToJson), [ToJsonFile](https://github.com/wagnerpt/W4G.Extensions/wiki/ToJson).
- **XML**: [ToXml](https://github.com/wagnerpt/W4G.Extensions/wiki/ToXml), [ToXmlFile](https://github.com/wagnerpt/W4G.Extensions/wiki/ToXml).

**Extensões para Números** ([detalhes](https://github.com/wagnerpt/W4G.Extensions/wiki/Extens%C3%B5es-para-N%C3%BAmeros))
[ToCurrency](https://github.com/wagnerpt/W4G.Extensions/wiki/ToCurrency), [ToExtensionMoneyBRL](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionMoneyBRL), [ToExtensionValueBR](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionValueBR).

**Extensões para Strings** ([detalhes](https://github.com/wagnerpt/W4G.Extensions/wiki/Extens%C3%B5es-para-Strings))
[NoAccents](https://github.com/wagnerpt/W4G.Extensions/wiki/NoAccents), [OnlyNumbers](https://github.com/wagnerpt/W4G.Extensions/wiki/OnlyNumbers).

## Como Utilizar

**Instalação via NuGet**: Você pode instalar as extensões via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:

```bash	
dotnet add package W4G.Extensions
```

Depois de instalar o pacote, você pode usar as extensões em seu código. Veja um exemplo de uso do método ToCurrency():

```csharp
using W4G.Extensions;

class Program
{
	static void Main(string[] args)
	{
		double value = 1234.56;
		string formattedValue = value.ToCurrency(); // R$ 1.234,56
		Console.WriteLine(formattedValue);
	}
}
```

## Contribuindo
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues para relatar bugs, sugerir novas funcionalidades ou enviar pull requests com melhorias.

## Licença
Este projeto é licenciado sob a MIT License.

Este README.md fornece uma visão geral do repositório, lista os recursos disponíveis, explica como instalar e usar as extensões, e também encoraja contribuições.
