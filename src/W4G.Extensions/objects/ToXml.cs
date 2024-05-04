using Newtonsoft.Json;
using System.Xml.Serialization;

namespace W4G.Extensions;

public static class ToXmlExtensions
{
    public static string ToXml<T>(this T obj)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, obj);
        return writer.ToString();
    }
}
