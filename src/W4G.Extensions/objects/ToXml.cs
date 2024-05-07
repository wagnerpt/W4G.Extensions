using System.Text;
using System.Xml.Serialization;

namespace W4G.Extensions;

public static class ToXmlExtensions
{
    /// <summary>
    /// Serializa o objeto especificado em uma string XML.
    /// </summary>
    /// <typeparam name="T">O tipo objeto a ser serializado</typeparam>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <returns>Uma representação de string XML do objeto.</returns>
    public static string ToXml<T>(this T value)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, value);
        return writer.ToString();
    }


    /// <summary>
    /// Serializa o objeto especificado em uma string XML e salva em arquivo.
    /// </summary>
    /// <typeparam name="T">O tipo objeto a ser serializado</typeparam>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="path">O arquivo onde será gravado</param>
    public static void ToJsonFile<T>(this T value, string path)
    {
        File.WriteAllText(path, value.ToXml());
    }

    /// <summary>
    /// Serializa o objeto especificado em uma string XML e salva em arquivo.
    /// </summary>
    /// <typeparam name="T">O tipo objeto a ser serializado</typeparam>
    /// <param name="value">O objeto a ser serializado.</param>
    /// <param name="path">O arquivo onde será gravado</param>
    /// <param name="encoding">A codificação a ser aplicada à string.</param>
    public static void ToJsonFile<T>(this T value, string path, Encoding encoding)
    {
        File.WriteAllText(path, value.ToXml(), encoding);
    }

    /// <summary>
    /// Desserializa um XML em um objeto do tipo especificado.
    /// </summary>
    /// <typeparam name="T">O tipo de objeto para desserialização.</typeparam>
    /// <param name="xml">O XML a ser desserializado.</param>
    /// <returns>O objeto desserializado.</returns>
    /// <exception cref="ArgumentException">É lançada quando o XML fornecido é nulo ou vazio.</exception>
    public static T FromXml<T>(this string xml) where T : class, new()
    {
        if (string.IsNullOrWhiteSpace(xml))
            throw new ArgumentException("O XML não pode estar vazio ou nulo.", nameof(xml));

        var xmlSerializer = new XmlSerializer(typeof(T));
        using (var stringReader = new StringReader(xml))
        {
            return xmlSerializer.Deserialize(stringReader) as T ?? new T();
        }
    }
}
