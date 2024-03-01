// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosTargetListSelector : IUtf8JsonSerializable, IJsonModel<ChaosTargetListSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosTargetListSelector>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChaosTargetListSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetListSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetListSelector)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectorType.ToString());
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Filter != null)
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
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

        ChaosTargetListSelector IJsonModel<ChaosTargetListSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetListSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetListSelector)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosTargetListSelector(document.RootElement, options);
        }

        internal static ChaosTargetListSelector DeserializeChaosTargetListSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ChaosTargetReference> targets = default;
            SelectorType type = default;
            string id = default;
            ChaosTargetFilter filter = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"u8))
                {
                    List<ChaosTargetReference> array = new List<ChaosTargetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChaosTargetReference.DeserializeChaosTargetReference(item, options));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SelectorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ChaosTargetFilter.DeserializeChaosTargetFilter(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ChaosTargetListSelector(type, id, filter, additionalProperties, targets);
        }

        BinaryData IPersistableModel<ChaosTargetListSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetListSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetListSelector)} does not support '{options.Format}' format.");
            }
        }

        ChaosTargetListSelector IPersistableModel<ChaosTargetListSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetListSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosTargetListSelector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetListSelector)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosTargetListSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
