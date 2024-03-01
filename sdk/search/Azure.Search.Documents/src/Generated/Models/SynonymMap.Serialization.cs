// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SynonymMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format);
            writer.WritePropertyName("synonyms"u8);
            writer.WriteStringValue(Synonyms);
            if (EncryptionKey != null)
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SynonymMap DeserializeSynonymMap(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string format = default;
            string synonyms = default;
            SearchResourceEncryptionKey encryptionKey = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synonyms"u8))
                {
                    synonyms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SynonymMap(name, format, synonyms, encryptionKey, odataEtag);
        }
    }
}
