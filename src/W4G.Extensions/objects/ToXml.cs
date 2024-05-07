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
}
