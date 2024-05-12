using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace W4G.Extensions;

public static class JsonExtensions
{
    /// <summary>
    /// Serializa o objeto especificado em uma string JSON.
    /// </summary>
    /// <param name="obj">O objeto a ser serializado.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value)
    {
        return JsonConvert.SerializeObject(value);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando formatação.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="formatting">Indica como a saída deve ser formatada.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, Formatting formatting)
    {
        return JsonConvert.SerializeObject(value, formatting);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando uma coleção de Newtonsoft.Json.JsonConverter.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="converters">Uma coleção de conversores usados ​​durante a serialização.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, params JsonConverter[] converters)
    {
        return JsonConvert.SerializeObject(value, converters);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando formatação e uma coleção de Newtonsoft.Json.JsonConverter.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="formatting">Indica como a saída deve ser formatada.</param>
    /// <param name="converters">Uma coleção de conversores usados ​​durante a serialização.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, Formatting formatting, params JsonConverter[] converters)
    {
        return JsonConvert.SerializeObject(value, formatting, converters);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando Newtonsoft.Json.JsonSerializerSettings.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="settings">O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se este for nulo, as configurações de serialização padrão serão usadas.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, JsonSerializerSettings settings)
    {
        return JsonConvert.SerializeObject(value, settings);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando um tipo, formatação e Newtonsoft.Json.JsonSerializerSettings.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="type">O tipo do valor que está sendo serializado. Este parâmetro é usado quando Newtonsoft.Json.JsonSerializer.TypeNameHandling é Newtonsoft.Json.TypeNameHandling.Auto para gravar o nome do tipo se o tipo do valor não corresponder.</param>
    /// <param name="settings">O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se for nulo, as configurações de serialização padrão serão usadas.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, Type type, JsonSerializerSettings settings)
    {
        return JsonConvert.SerializeObject(value, type, settings);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando formatação e Newtonsoft.Json.JsonSerializerSettings.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="formatting">Indica como a saída deve ser formatada.</param>
    /// <param name="settings">O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se for nulo, as configurações de serialização padrão serão usadas.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, Formatting formatting, JsonSerializerSettings settings)
    {
        return JsonConvert.SerializeObject(value, formatting, settings);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON usando um tipo, formatação e Newtonsoft.Json.JsonSerializerSettings.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="type">O tipo do valor que está sendo serializado. Este parâmetro é usado quando Newtonsoft.Json.JsonSerializer.TypeNameHandling é Newtonsoft.Json.TypeNameHandling.Auto para gravar o nome do tipo se o tipo do valor não corresponder. opcional.</param>
    /// <param name="formatting">Indica como a saída deve ser formatada.</param>
    /// <param name="settings">O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se for nulo, as configurações de serialização padrão serão usadas.</param>
    /// <returns>Uma representação de string JSON do objeto.</returns>
    public static string ToJson(this object value, Type type, Formatting formatting, JsonSerializerSettings settings)
    {
        return JsonConvert.SerializeObject(value, type, formatting, settings);
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON e salva em arquivo.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="path">O arquivo para gravação.</param>
    public static void ToJsonFile(this object value, string path)
    {
        File.WriteAllText(path, value.ToJson());
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string JSON e salva em arquivo.
    /// </summary>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="path">O arquivo para gravação.</param>
    /// <param name="encoding">A codificação a ser aplicada à cadeia de caracteres.</param>
    public static void ToJsonFile(this object value, string path, Encoding encoding)
    {
        File.WriteAllText(path, value.ToJson(), encoding);
    }

    /// <summary>
    /// Desserializa um JSON em um objeto do tipo especificado.
    /// </summary>
    /// <typeparam name="T">O tipo de objeto para desserialização.</typeparam>
    /// <param name="value">O JSON a ser desserializado.</param>
    /// <returns>O objeto desserializado.</returns>
    public static T FromJson<T>(this string value) where T : class, new()
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        return JsonConvert.DeserializeObject<T>(value) ?? new T();
    }

    /// <summary>
    /// Desserializa um JSON em um objeto do tipo especificado usanado JsonConverter.
    /// </summary>
    /// <typeparam name="T">O tipo de objeto para desserialização.</typeparam>
    /// <param name="value">O JSON a ser desserializado.</param>
    /// <param name="converters">Uma coleção de conversores usados ​​durante a serialização.</param>
    /// <returns>O objeto desserializado.</returns>
    public static T FromJson<T>(this string value, params JsonConverter[] converters) where T : class, new()
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        return JsonConvert.DeserializeObject<T>(value, converters) ?? new T();
    }

    /// <summary>
    /// Desserializa um JSON em um objeto do tipo especificado usando JsonSerializerSettings.
    /// </summary>
    /// <typeparam name="T">O tipo de objeto para desserialização.</typeparam>
    /// <param name="value">O JSON a ser desserializado.</param>
    /// <param name="settings">O Newtonsoft.Json.JsonSerializerSettings usado para serializar o objeto. Se for nulo, as configurações de serialização padrão serão usadas.</param>
    /// <returns>O objeto desserializado.</returns>
    public static T FromJson<T>(this string value, JsonSerializerSettings settings) where T : class, new()
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        return JsonConvert.DeserializeObject<T>(value, settings) ?? new T();
    }
}
