namespace W4G.Extensions;

/// <summary>
/// 
/// </summary>
public static class AreEqualsExtensions
{
    /// <summary>
    /// Compara as propriedades públicas do objeto com as propriedades do outro objeto, retornando true se forem iguais e false caso contrário.
    /// </summary>
    /// <typeparam name="T">O tipo de objeto para comparação.</typeparam>
    /// <param name="obj">O objeto a ser desserializado.</param>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj">Este objeto que será comparado</param>
    /// <param name="otherObject">O outro objeto a ser comparado</param>
    /// <returns></returns>
    public static bool AreEquals(this object obj, object otherObject)
    {
        if (obj == null || otherObject == null)
            return obj == null && otherObject == null;

        if (obj.GetType() != otherObject.GetType())
            return false;

        if (obj.GetType().IsClass && obj.GetType() != typeof(string))
        {
            // If both objects are classes, recursively compare their properties
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var thisValue = property.GetValue(obj, null);
                var otherValue = property.GetValue(otherObject, null);

                if (!AreEquals(thisValue, otherValue))
                    return false;
            }
            return true;
        }

        return obj.Equals(otherObject);
    }
}
