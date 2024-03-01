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

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class LogAnalyticsQueryPackData : IUtf8JsonSerializable, IJsonModel<LogAnalyticsQueryPackData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogAnalyticsQueryPackData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogAnalyticsQueryPackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsQueryPackData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogAnalyticsQueryPackData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && QueryPackId.HasValue)
            {
                writer.WritePropertyName("queryPackId"u8);
                writer.WriteStringValue(QueryPackId.Value);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && ModifiedOn.HasValue)
            {
                writer.WritePropertyName("timeModified"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        LogAnalyticsQueryPackData IJsonModel<LogAnalyticsQueryPackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsQueryPackData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogAnalyticsQueryPackData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogAnalyticsQueryPackData(document.RootElement, options);
        }

        internal static LogAnalyticsQueryPackData DeserializeLogAnalyticsQueryPackData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? queryPackId = default;
            DateTimeOffset? timeCreated = default;
            DateTimeOffset? timeModified = default;
            string provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("queryPackId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryPackId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("timeCreated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeCreated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("timeModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
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
            return new LogAnalyticsQueryPackData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                queryPackId,
                timeCreated,
                timeModified,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogAnalyticsQueryPackData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsQueryPackData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogAnalyticsQueryPackData)} does not support '{options.Format}' format.");
            }
        }

        LogAnalyticsQueryPackData IPersistableModel<LogAnalyticsQueryPackData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsQueryPackData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogAnalyticsQueryPackData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogAnalyticsQueryPackData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogAnalyticsQueryPackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
