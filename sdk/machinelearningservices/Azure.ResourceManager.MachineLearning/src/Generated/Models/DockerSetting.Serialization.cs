// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DockerSetting : IUtf8JsonSerializable, IJsonModel<DockerSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DockerSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DockerSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DockerSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DockerSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Privileged.HasValue)
            {
                if (Privileged != null)
                {
                    writer.WritePropertyName("privileged"u8);
                    writer.WriteBooleanValue(Privileged.Value);
                }
                else
                {
                    writer.WriteNull("privileged");
                }
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

        DockerSetting IJsonModel<DockerSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DockerSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DockerSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDockerSetting(document.RootElement, options);
        }

        internal static DockerSetting DeserializeDockerSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? privileged = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privileged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privileged = null;
                        continue;
                    }
                    privileged = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DockerSetting(privileged, additionalProperties);
        }

        BinaryData IPersistableModel<DockerSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DockerSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DockerSetting)} does not support '{options.Format}' format.");
            }
        }

        DockerSetting IPersistableModel<DockerSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DockerSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDockerSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DockerSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DockerSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
