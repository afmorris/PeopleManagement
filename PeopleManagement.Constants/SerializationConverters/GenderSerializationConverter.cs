using System;
using Newtonsoft.Json;

namespace PeopleManagement.Constants.SerializationConverters
{
    public class GenderSerializationConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((value as Gender)?.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");

        public override bool CanRead => false;

        public override bool CanConvert(Type objectType) => objectType == typeof(Gender);
    }
}