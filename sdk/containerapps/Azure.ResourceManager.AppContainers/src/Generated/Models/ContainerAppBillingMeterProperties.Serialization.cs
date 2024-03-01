// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppBillingMeterProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppBillingMeterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppBillingMeterProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppBillingMeterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBillingMeterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppBillingMeterProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (WorkloadProfileCategory != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(WorkloadProfileCategory);
            }
            if (MeterType != null)
            {
                writer.WritePropertyName("meterType"u8);
                writer.WriteStringValue(MeterType);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
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

        ContainerAppBillingMeterProperties IJsonModel<ContainerAppBillingMeterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBillingMeterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppBillingMeterProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppBillingMeterProperties(document.RootElement, options);
        }

        internal static ContainerAppBillingMeterProperties DeserializeContainerAppBillingMeterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string category = default;
            string meterType = default;
            string displayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterType"u8))
                {
                    meterType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppBillingMeterProperties(category, meterType, displayName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppBillingMeterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBillingMeterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppBillingMeterProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppBillingMeterProperties IPersistableModel<ContainerAppBillingMeterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppBillingMeterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppBillingMeterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppBillingMeterProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppBillingMeterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
