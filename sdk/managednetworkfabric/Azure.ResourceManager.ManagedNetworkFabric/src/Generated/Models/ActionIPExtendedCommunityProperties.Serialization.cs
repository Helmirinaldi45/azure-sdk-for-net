// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ActionIPExtendedCommunityProperties : IUtf8JsonSerializable, IJsonModel<ActionIPExtendedCommunityProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActionIPExtendedCommunityProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ActionIPExtendedCommunityProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionIPExtendedCommunityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionIPExtendedCommunityProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Delete != null)
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
            }
            if (Set != null)
            {
                writer.WritePropertyName("set"u8);
                writer.WriteObjectValue(Set);
            }
            if (Add != null)
            {
                writer.WritePropertyName("add"u8);
                writer.WriteObjectValue(Add);
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

        ActionIPExtendedCommunityProperties IJsonModel<ActionIPExtendedCommunityProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionIPExtendedCommunityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionIPExtendedCommunityProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActionIPExtendedCommunityProperties(document.RootElement, options);
        }

        internal static ActionIPExtendedCommunityProperties DeserializeActionIPExtendedCommunityProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPExtendedCommunityIdList delete = default;
            IPExtendedCommunityIdList @set = default;
            IPExtendedCommunityIdList @add = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value, options);
                    continue;
                }
                if (property.NameEquals("set"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @set = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value, options);
                    continue;
                }
                if (property.NameEquals("add"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @add = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ActionIPExtendedCommunityProperties(@add, serializedAdditionalRawData, delete, @set);
        }

        BinaryData IPersistableModel<ActionIPExtendedCommunityProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionIPExtendedCommunityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ActionIPExtendedCommunityProperties)} does not support '{options.Format}' format.");
            }
        }

        ActionIPExtendedCommunityProperties IPersistableModel<ActionIPExtendedCommunityProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionIPExtendedCommunityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActionIPExtendedCommunityProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActionIPExtendedCommunityProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActionIPExtendedCommunityProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
