Devolve o objeto serializado em uma string no formato JSON.

```csharp
string ToJson()
string ToJson(Formatting formatting)
string ToJson(params JsonConverter[] converters)
string ToJson(Formatting formatting, params JsonConverter[] converters)
string ToJson(JsonSerializerSettings settings)
string ToJson(Type? type, JsonSerializerSettings? settings)
string ToJson(Formatting formatting, JsonSerializerSettings settings)
string ToJson(Type? type, Formatting formatting, JsonSerializerSettings? settings)
```

## Dependencies
Newtonsoft.Json (>= 13.0.1) - Versões anteriores foram apontadas com vulnerabilidade. Caso seu projeto utilize uma versão anterior, recomendamos fortemente a atualização.

## Extends
Todos objetos.

## Parameters:
- **formatting**: Indica como a saída deve ser formatada.
- **converters**: Uma coleção de conversores usados ​​durante a serialização.
- **settings**: O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se for nulo, as configurações de serialização padrão serão usadas.
- **type**: O tipo do valor que está sendo serializado. Este parâmetro é usado quando Newtonsoft.Json.JsonSerializer.TypeNameHandling é Newtonsoft.Json.TypeNameHandling.Auto para gravar o nome do tipo se o tipo do valor não corresponder.

## Exemplos de Utilização
```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        var value = new { nome = "João", sobrenome = "Silva", endereco= new { rua = "Rua Um", numero = "2", cep = "00001-001" };
        Console.WriteLine(value.ToJson());
    }
}
```
Output:
```json
{"nome":"João","sobrenome":"Silva","endereco":{"rua":"Rua Um","numero":"2","cep":"00001-001"}}
```