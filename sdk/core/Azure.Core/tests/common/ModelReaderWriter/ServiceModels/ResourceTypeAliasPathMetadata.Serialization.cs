// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.Models.ResourceManager.Resources
{
    public partial class ResourceTypeAliasPathMetadata : IUtf8JsonSerializable, IJsonModel<ResourceTypeAliasPathMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAliasPathMetadata>)this).Write(writer, ModelReaderWriterOptions.Wire);

        internal static ResourceTypeAliasPathMetadata DeserializeResourceTypeAliasPathMetadata(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceTypeAliasPathTokenType> type = default;
            Optional<ResourceTypeAliasPathAttributes> attributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceTypeAliasPathTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = new ResourceTypeAliasPathAttributes(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceTypeAliasPathMetadata(Optional.ToNullable(type), Optional.ToNullable(attributes));
        }

        void IJsonModel<ResourceTypeAliasPathMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TokenType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TokenType.ToString());
            }
            if (Optional.IsDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStringValue(Attributes.ToString());
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasPathMetadataProperties
        {
            public Optional<ResourceTypeAliasPathTokenType> TokenType { get; set; }
            public Optional<ResourceTypeAliasPathAttributes> Attributes { get; set; }
        }

        ResourceTypeAliasPathMetadata IJsonModel<ResourceTypeAliasPathMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPathMetadata(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ResourceTypeAliasPathMetadataProperties properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("type"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.TokenType = new ResourceTypeAliasPathTokenType(reader.GetString());
                return;
            }
            if (propertyName.SequenceEqual("attributes"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Attributes = new ResourceTypeAliasPathAttributes(reader.GetString());
                return;
            }
            reader.Skip();
        }

        ResourceTypeAliasPathMetadata IPersistableModel<ResourceTypeAliasPathMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPathMetadata(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ResourceTypeAliasPathMetadata>.Write(ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ResourceTypeAliasPathMetadata>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
