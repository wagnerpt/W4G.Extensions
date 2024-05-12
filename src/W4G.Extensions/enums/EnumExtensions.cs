using System.ComponentModel;
using System.Reflection;

namespace W4G.Extensions;

/// <summary>
/// Contem métodos de extensão para <see cref="Enum"/>.
/// </summary>
static public class EnumExtensions
{
    /// <summary>
    /// Pega a descrição do valor de um Enum
    /// </summary>
    /// <param name="value">Enum com <see cref="DescriptionAttribute"/> descrição</param>
    /// <returns>A descrição do valor de Enum.</returns>
    public static string Description(this Enum value)
    {
        MemberInfo[] member = value.GetType().GetMember(value.ToString());
        if (member != null && member.Length != 0)
        {
            object[] customAttributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
            if (customAttributes != null && customAttributes.Length != 0)
            {
                return ((DescriptionAttribute)customAttributes[0]).Description;
            }
        }

        return value.ToString();
    }

    /// <summary>
    /// Verifica se o enum especificado, <paramref name="object"/>, é um membro válido do Enum.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="object">O suposto membro do enum</param>
    /// <param name="acceptUndefined">Se indefinido é aceito como um Enum válido</param>
    /// <param name="undefinedEnumName">Descrição do valor do enum indefinido.</param>
    /// <returns>Se <paramref name="object"/> é um membro válido do enum</returns>
    static public bool IsValid<TEnum>(this Enum @object, bool acceptUndefined = true, string undefinedEnumName = "Undefined")
    {
        if (@object == null)
            return false;

        var validEnum = Enum.IsDefined(typeof(TEnum), @object) && !@object.Equals(default(Enum));
        if (validEnum && !acceptUndefined)
            return !@object.ToString().Equals(undefinedEnumName);

        return validEnum;
    }

    /// <summary>
    /// Verifica se um valor específico existe em um enum.
    /// </summary>
    /// <typeparam name="TEnum">O tipo do enum.</typeparam>
    /// <param name="value">O valor a ser verificado.</param>
    /// <returns>True se o valor existir no enum, caso contrário false.</returns>
    public static bool HasValue<TEnum>(this TEnum value) where TEnum : Enum
    {
        return Enum.IsDefined(typeof(TEnum), value);
    }

    /// <summary>
    /// Converte um enum em uma lista de seus valores.
    /// </summary>
    /// <typeparam name="Enum">O tipo do enum.</typeparam>
    /// <returns>Uma lista contendo os valores do enum.</returns>
    public static List<TEnum> ToList<TEnum>()
    {
        return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
    }
}