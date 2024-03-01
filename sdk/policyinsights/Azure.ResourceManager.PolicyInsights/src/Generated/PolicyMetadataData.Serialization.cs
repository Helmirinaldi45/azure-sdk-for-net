// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyMetadataData : IUtf8JsonSerializable, IJsonModel<PolicyMetadataData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyMetadataData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyMetadataData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && MetadataId != null)
            {
                writer.WritePropertyName("metadataId"u8);
                writer.WriteStringValue(MetadataId);
            }
            if (options.Format != "W" && Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && Title != null)
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Owner != null)
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (options.Format != "W" && AdditionalContentUri != null)
            {
                writer.WritePropertyName("additionalContentUrl"u8);
                writer.WriteStringValue(AdditionalContentUri.AbsoluteUri);
            }
            if (options.Format != "W" && Metadata != null)
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Requirements != null)
            {
                writer.WritePropertyName("requirements"u8);
                writer.WriteStringValue(Requirements);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PolicyMetadataData IJsonModel<PolicyMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyMetadataData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyMetadataData(document.RootElement, options);
        }

        internal static PolicyMetadataData DeserializePolicyMetadataData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string metadataId = default;
            string category = default;
            string title = default;
            string owner = default;
            Uri additionalContentUrl = default;
            BinaryData metadata = default;
            string description = default;
            string requirements = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("metadataId"u8))
                        {
                            metadataId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("category"u8))
                        {
                            category = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("owner"u8))
                        {
                            owner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalContentUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            additionalContentUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requirements"u8))
                        {
                            requirements = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyMetadataData(
                id,
                name,
                type,
                systemData,
                metadataId,
                category,
                title,
                owner,
                additionalContentUrl,
                metadata,
                description,
                requirements,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyMetadataData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyMetadataData)} does not support '{options.Format}' format.");
            }
        }

        PolicyMetadataData IPersistableModel<PolicyMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyMetadataData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyMetadataData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
