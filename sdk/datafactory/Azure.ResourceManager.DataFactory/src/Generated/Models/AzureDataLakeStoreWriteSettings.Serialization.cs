// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDataLakeStoreWriteSettings : IUtf8JsonSerializable, IJsonModel<AzureDataLakeStoreWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDataLakeStoreWriteSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDataLakeStoreWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStoreWriteSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExpiryDateTime))
            {
                writer.WritePropertyName("expiryDateTime"u8);
                JsonSerializer.Serialize(writer, ExpiryDateTime);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreWriteSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior"u8);
                JsonSerializer.Serialize(writer, CopyBehavior);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        AzureDataLakeStoreWriteSettings IJsonModel<AzureDataLakeStoreWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataLakeStoreWriteSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataLakeStoreWriteSettings(document.RootElement, options);
        }

        internal static AzureDataLakeStoreWriteSettings DeserializeAzureDataLakeStoreWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> expiryDateTime = default;
            string type = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            Optional<DataFactoryElement<string>> copyBehavior = default;
            Optional<IList<DataFactoryMetadataItemInfo>> metadata = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiryDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryDateTime = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryMetadataItemInfo> array = new List<DataFactoryMetadataItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryMetadataItemInfo.DeserializeDataFactoryMetadataItemInfo(item));
                    }
                    metadata = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDataLakeStoreWriteSettings(type, maxConcurrentConnections.Value, disableMetricsCollection.Value, copyBehavior.Value, Optional.ToList(metadata), additionalProperties, expiryDateTime.Value);
        }

        BinaryData IPersistableModel<AzureDataLakeStoreWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDataLakeStoreWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        AzureDataLakeStoreWriteSettings IPersistableModel<AzureDataLakeStoreWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataLakeStoreWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDataLakeStoreWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDataLakeStoreWriteSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDataLakeStoreWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
