// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightDiskBillingMeters : IUtf8JsonSerializable, IJsonModel<HDInsightDiskBillingMeters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightDiskBillingMeters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightDiskBillingMeters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightDiskBillingMeters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightDiskBillingMeters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DiskRpMeter != null)
            {
                writer.WritePropertyName("diskRpMeter"u8);
                writer.WriteStringValue(DiskRpMeter);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Tier.HasValue)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
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

        HDInsightDiskBillingMeters IJsonModel<HDInsightDiskBillingMeters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightDiskBillingMeters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightDiskBillingMeters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightDiskBillingMeters(document.RootElement, options);
        }

        internal static HDInsightDiskBillingMeters DeserializeHDInsightDiskBillingMeters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskRpMeter = default;
            string sku = default;
            HDInsightTier? tier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskRpMeter"u8))
                {
                    diskRpMeter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new HDInsightTier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightDiskBillingMeters(diskRpMeter, sku, tier, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightDiskBillingMeters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightDiskBillingMeters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightDiskBillingMeters)} does not support '{options.Format}' format.");
            }
        }

        HDInsightDiskBillingMeters IPersistableModel<HDInsightDiskBillingMeters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightDiskBillingMeters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightDiskBillingMeters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightDiskBillingMeters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightDiskBillingMeters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
