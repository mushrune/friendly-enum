using System.Reflection;
using Newtonsoft.Json;

namespace FriendlyEnum;

public class FriendlyEnumConverter<T> : JsonConverter<T> where T : FriendlyEnum
{
    public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
    {
        writer.WriteValue( value.ToString() ); 
    }

    public override T ReadJson(
        JsonReader reader, 
        Type objectType, 
        T existingValue, 
        bool hasExistingValue, 
        JsonSerializer serializer ) 
    {
        var s = (string)reader.Value;

        var properties = typeof(T)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(p => p.PropertyType == typeof(T));

        foreach (var property in properties)
        {
            var propertyValue = (T)property.GetValue(null);
            if (propertyValue.Value == s)
            {
                return propertyValue;
            }
        }

        return (T) properties.FirstOrDefault().GetValue(null);
    }
}