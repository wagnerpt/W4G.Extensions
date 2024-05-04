using Newtonsoft.Json;

namespace W4G.Extensions;

public static class ToJsonExtensions
{
    public static string ToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
}
