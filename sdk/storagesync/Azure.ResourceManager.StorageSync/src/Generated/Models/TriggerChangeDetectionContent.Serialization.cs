// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class TriggerChangeDetectionContent : IUtf8JsonSerializable, IJsonModel<TriggerChangeDetectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TriggerChangeDetectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TriggerChangeDetectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerChangeDetectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggerChangeDetectionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DirectoryPath != null)
            {
                writer.WritePropertyName("directoryPath"u8);
                writer.WriteStringValue(DirectoryPath);
            }
            if (ChangeDetectionMode.HasValue)
            {
                writer.WritePropertyName("changeDetectionMode"u8);
                writer.WriteStringValue(ChangeDetectionMode.Value.ToString());
            }
            if (!(Paths is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
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

        TriggerChangeDetectionContent IJsonModel<TriggerChangeDetectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerChangeDetectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TriggerChangeDetectionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerChangeDetectionContent(document.RootElement, options);
        }

        internal static TriggerChangeDetectionContent DeserializeTriggerChangeDetectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string directoryPath = default;
            ChangeDetectionMode? changeDetectionMode = default;
            IList<string> paths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directoryPath"u8))
                {
                    directoryPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeDetectionMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeDetectionMode = new ChangeDetectionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    paths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TriggerChangeDetectionContent(directoryPath, changeDetectionMode, paths ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TriggerChangeDetectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerChangeDetectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TriggerChangeDetectionContent)} does not support '{options.Format}' format.");
            }
        }

        TriggerChangeDetectionContent IPersistableModel<TriggerChangeDetectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerChangeDetectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTriggerChangeDetectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TriggerChangeDetectionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TriggerChangeDetectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
