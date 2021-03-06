using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DDD.Domain;

namespace DDD.Infrastructure.Converters
{
    public class DomainModelVersionConverter : JsonConverter<DomainModelVersion>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(DomainModelVersion) || typeToConvert == typeof(IDomainModelVersion);
        }

        public override DomainModelVersion Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
            DomainModelVersion.Create(reader.GetString());

        public override void Write(
            Utf8JsonWriter writer,
            DomainModelVersion domainModelVersionValue,
            JsonSerializerOptions options) =>
            writer.WriteStringValue(domainModelVersionValue.ToString());
    }
}
