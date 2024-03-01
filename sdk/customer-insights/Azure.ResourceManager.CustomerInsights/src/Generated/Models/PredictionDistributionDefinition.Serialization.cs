// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionDistributionDefinition : IUtf8JsonSerializable, IJsonModel<PredictionDistributionDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionDistributionDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionDistributionDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDistributionDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDistributionDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TotalPositives.HasValue)
            {
                writer.WritePropertyName("totalPositives"u8);
                writer.WriteNumberValue(TotalPositives.Value);
            }
            if (TotalNegatives.HasValue)
            {
                writer.WritePropertyName("totalNegatives"u8);
                writer.WriteNumberValue(TotalNegatives.Value);
            }
            if (!(Distributions is ChangeTrackingList<PredictionDistributionDefinitionDistributionsItem> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("distributions"u8);
                writer.WriteStartArray();
                foreach (var item in Distributions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PredictionDistributionDefinition IJsonModel<PredictionDistributionDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDistributionDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDistributionDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDistributionDefinition(document.RootElement, options);
        }

        internal static PredictionDistributionDefinition DeserializePredictionDistributionDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalPositives = default;
            long? totalNegatives = default;
            IReadOnlyList<PredictionDistributionDefinitionDistributionsItem> distributions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalPositives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalPositives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalNegatives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalNegatives = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("distributions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PredictionDistributionDefinitionDistributionsItem> array = new List<PredictionDistributionDefinitionDistributionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictionDistributionDefinitionDistributionsItem.DeserializePredictionDistributionDefinitionDistributionsItem(item, options));
                    }
                    distributions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PredictionDistributionDefinition(totalPositives, totalNegatives, distributions ?? new ChangeTrackingList<PredictionDistributionDefinitionDistributionsItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PredictionDistributionDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDistributionDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictionDistributionDefinition)} does not support '{options.Format}' format.");
            }
        }

        PredictionDistributionDefinition IPersistableModel<PredictionDistributionDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDistributionDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionDistributionDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionDistributionDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionDistributionDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
