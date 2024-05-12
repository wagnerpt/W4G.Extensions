Devolve o objeto serializado em uma string no formato JSON.

```csharp
void ToJsonFile(string path)
void ToJsonFile(string path, Encoding encoding)
```

## Dependencies
Newtonsoft.Json (>= 13.0.1) - Versões anteriores foram apontadas com vulnerabilidade. Caso seu projeto utilize uma versão anterior, recomendamos fortemente a atualização.

## Extends
Todos objetos.

## Parameters:
- **path**: O arquivo onde será gravado.
- **encoding**: A codificação a ser aplicada à string.

## Exemplos de Utilização
```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var value = new { nome = "João", sobrenome = "Silva", endereco= new { rua = "Rua Um", numero = "2", cep = "00001-001" };
        value.ToJsonFile("C:\\arquivo.json");
    }
}
```
Output:
```text
Arquivo gerado em "C:/arquivo.json" contendo:
{"nome":"João","sobrenome":"Silva","endereco":{"rua":"Rua Um","numero":"2","cep":"00001-001"}}
```