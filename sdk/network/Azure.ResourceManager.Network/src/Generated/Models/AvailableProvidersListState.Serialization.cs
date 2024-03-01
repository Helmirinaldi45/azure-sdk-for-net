// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersListState : IUtf8JsonSerializable, IJsonModel<AvailableProvidersListState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableProvidersListState>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailableProvidersListState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableProvidersListState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableProvidersListState)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StateName != null)
            {
                writer.WritePropertyName("stateName"u8);
                writer.WriteStringValue(StateName);
            }
            if (!(Providers is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("providers"u8);
                writer.WriteStartArray();
                foreach (var item in Providers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Cities is ChangeTrackingList<AvailableProvidersListCity> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("cities"u8);
                writer.WriteStartArray();
                foreach (var item in Cities)
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

        AvailableProvidersListState IJsonModel<AvailableProvidersListState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableProvidersListState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableProvidersListState)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableProvidersListState(document.RootElement, options);
        }

        internal static AvailableProvidersListState DeserializeAvailableProvidersListState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stateName = default;
            IReadOnlyList<string> providers = default;
            IReadOnlyList<AvailableProvidersListCity> cities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stateName"u8))
                {
                    stateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"u8))
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
                    providers = array;
                    continue;
                }
                if (property.NameEquals("cities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableProvidersListCity> array = new List<AvailableProvidersListCity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableProvidersListCity.DeserializeAvailableProvidersListCity(item, options));
                    }
                    cities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailableProvidersListState(stateName, providers ?? new ChangeTrackingList<string>(), cities ?? new ChangeTrackingList<AvailableProvidersListCity>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableProvidersListState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableProvidersListState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailableProvidersListState)} does not support '{options.Format}' format.");
            }
        }

        AvailableProvidersListState IPersistableModel<AvailableProvidersListState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableProvidersListState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailableProvidersListState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableProvidersListState)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableProvidersListState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
