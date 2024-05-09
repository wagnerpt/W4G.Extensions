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
        static public string GetDescription(this Enum value) =>
            value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;

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
            var validEnum = Enum.IsDefined(typeof(TEnum), @object) && !@object.Equals(default(Enum));
            if (validEnum && !acceptUndefined)
            {
                return !@object.ToString().Equals(undefinedEnumName);
            }
            return validEnum;
        }
    }
}