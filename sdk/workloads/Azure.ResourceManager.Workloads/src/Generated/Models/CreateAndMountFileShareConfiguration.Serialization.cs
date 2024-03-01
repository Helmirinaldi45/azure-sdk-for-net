// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CreateAndMountFileShareConfiguration : IUtf8JsonSerializable, IJsonModel<CreateAndMountFileShareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateAndMountFileShareConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateAndMountFileShareConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndMountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateAndMountFileShareConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (StorageAccountName != null)
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        CreateAndMountFileShareConfiguration IJsonModel<CreateAndMountFileShareConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndMountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateAndMountFileShareConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateAndMountFileShareConfiguration(document.RootElement, options);
        }

        internal static CreateAndMountFileShareConfiguration DeserializeCreateAndMountFileShareConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceGroup = default;
            string storageAccountName = default;
            ConfigurationType configurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateAndMountFileShareConfiguration(configurationType, serializedAdditionalRawData, resourceGroup, storageAccountName);
        }

        BinaryData IPersistableModel<CreateAndMountFileShareConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndMountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateAndMountFileShareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CreateAndMountFileShareConfiguration IPersistableModel<CreateAndMountFileShareConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateAndMountFileShareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateAndMountFileShareConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateAndMountFileShareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateAndMountFileShareConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
