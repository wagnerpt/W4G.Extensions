using System.ComponentModel;
using System.Reflection;

namespace W4G.Extensions
{
    /// <summary>
    /// Contem métodos de entensão para <see cref="Enum"/>.
    /// </summary>
    static public class EnumExtensions
    {
        /// <summary>
        /// Pega a descrição do valor de um Enum
        /// </summary>
        /// <param name="value">Enum com <see cref="DescriptionAttribute"/> descriçaõ</param>
        /// <returns>A descrição do valor de Enum.</returns>
        static public string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var descriptionAttribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return descriptionAttribute?.Description ?? string.Empty;
        }

        /// <summary>
        /// Verifica se o enum especificado, <paramref name="object"/>, é um membro válido do Enum.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="object">O suposto membro do enum</param>
        /// <param name="acceptUndefined">Se indefinido é aceito como um Enum válido</param>
        /// <param name="undefinedEnumName">Descrição do valor do enum indefinido.</param>
        /// <returns>Se <paramref name="object"/> é um membro válido do enum</returns>
        static public bool IsValidEnum<TEnum>(
            this Enum @object,
            bool acceptUndefined = true,
            string undefinedEnumName = "Undefined")
        {
            if (@object == null)
            {
                return false;
            }

            var validEnum = Enum.IsDefined(typeof(TEnum), @object) && !@object.Equals(default(Enum));
            if (validEnum && !acceptUndefined)
            {
                return !@object.ToString().Equals(undefinedEnumName);
            }

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
}