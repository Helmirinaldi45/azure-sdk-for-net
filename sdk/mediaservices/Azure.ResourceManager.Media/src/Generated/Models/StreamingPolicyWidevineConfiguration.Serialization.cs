// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingPolicyWidevineConfiguration : IUtf8JsonSerializable, IJsonModel<StreamingPolicyWidevineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyWidevineConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingPolicyWidevineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CustomLicenseAcquisitionUriTemplate != null)
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate);
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

        StreamingPolicyWidevineConfiguration IJsonModel<StreamingPolicyWidevineConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyWidevineConfiguration(document.RootElement, options);
        }

        internal static StreamingPolicyWidevineConfiguration DeserializeStreamingPolicyWidevineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customLicenseAcquisitionUriTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"u8))
                {
                    customLicenseAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingPolicyWidevineConfiguration(customLicenseAcquisitionUriTemplate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyWidevineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support '{options.Format}' format.");
            }
        }

        StreamingPolicyWidevineConfiguration IPersistableModel<StreamingPolicyWidevineConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingPolicyWidevineConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPolicyWidevineConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
