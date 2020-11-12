﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SwedbankPay.Sdk.JsonSerialization.Converters
{
    public class CustomUriConverter : JsonConverter<Uri>
    {
        public override Uri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                reader.GetString();
                reader.Read();
            }

            if (reader.TokenType == JsonTokenType.StartObject)
            {
                if (reader.Read())
                {
                    var uri = Read(ref reader, typeToConvert, options);
                    // Reads the EndObject
                    reader.Read();
                    return uri;
                }

            }

            if (reader.TokenType == JsonTokenType.String)
            {
                return new Uri(reader.GetString(), UriKind.RelativeOrAbsolute);
            }

            throw new JsonException();
        }


        public override void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
            writer.WriteStringValue(value.OriginalString);
        }
    }
}