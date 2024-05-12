## Documentos
#### CPF
- **[CpfIsValid](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfIsValid)**: Validação de CPF.
- **[CpfCorrect](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfCorrect)**: Devolve o CPF informado com os dígitos corretos.
- **[CpfFormat](https://github.com/wagnerpt/W4G.Extensions/wiki/CpfFormat)**: Aplica máscara ao CPF informado.
#### CNPJ
- **[CnpjIsValid](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjIsValid)**: Validação de CNPJ.
- **[CnpjCorrect](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjCorrect)**: Devolve o CNPJ informado com os dígitos corretos.
- **[CnpjFormat](https://github.com/wagnerpt/W4G.Extensions/wiki/CnpjFormat)**: Aplica máscara ao CNPJ informado.

## Enums
- **[Description](https://github.com/wagnerpt/W4G.Extensions/wiki/Enum.Description)**: Pega a descrição do valor de um Enum.
- **[IsValid](https://github.com/wagnerpt/W4G.Extensions/wiki/Enum.IsValid)**: Verifica se o enum especificado, é um membro válido do Enum.
- **[HasValue](https://github.com/wagnerpt/W4G.Extensions/wiki/Enum.HasValue)**: Verifica se um valor específico existe em um enum.
- **[ToList](https://github.com/wagnerpt/W4G.Extensions/wiki/Enum.ToList)**: Converte um enum em uma lista de seus valores.

## Números
- **[ToCurrency](https://github.com/wagnerpt/W4G.Extensions/wiki/ToCurrency)**: Formatação de valores monetários. Aplica-se a: tipos int, double ou decimal.
- **[ToExtensionMoneyBRL](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionMoneyBRL)**: Retorna o valor por extenso em reais (R$). Aplica-se a: tipos int, long, double ou decimal.
- **[ToExtensionValueBR](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionValueBR)**: Retorna o número por extenso em português. Aplica-se a: tipos int, long, double ou decimal.

## Objects
- **[AreEquals](https://github.com/wagnerpt/W4G.Extensions/wiki/AreEquals)**: Compara as propriedades públicas do objeto com as propriedades do outro objeto, retornando true se forem iguais e false caso contrário. Pode ser utilizado para implementar dentro do método Equals em classes de forma genérica.

## Serialização
#### Json
- **[FromJson](https://github.com/wagnerpt/W4G.Extensions/wiki/FromJson)**:  Desserializa um Json em um objeto do tipo especificado.
- **[ToJson](https://github.com/wagnerpt/W4G.Extensions/wiki/ToJson)**:  Serializa o objeto especificado em uma string JSON.
- **[ToJsonFile](https://github.com/wagnerpt/W4G.Extensions/wiki/ToJsonFile)**:  Serializa o objeto especificado em uma string JSON e salva em arquivo.
#### XML
- **[FromXml](https://github.com/wagnerpt/W4G.Extensions/wiki/FromXml)**:  Desserializa um XML em um objeto do tipo especificado.
- **[ToXml](https://github.com/wagnerpt/W4G.Extensions/wiki/ToXml)**:  Serializa o objeto especificado em uma string XML.
- **[ToXmlFile](https://github.com/wagnerpt/W4G.Extensions/wiki/ToXmlFile)**: Serializa o objeto especificado em uma string XML e salva em arquivo.

## Strings
- **[NoAccents](https://github.com/wagnerpt/W4G.Extensions/wiki/NoAccents)**: Remove acentos e "ç" de uma string.
- **[OnlyNumbers](https://github.com/wagnerpt/W4G.Extensions/wiki/OnlyNumbers)**: Retorna somente os números contido em uma string.