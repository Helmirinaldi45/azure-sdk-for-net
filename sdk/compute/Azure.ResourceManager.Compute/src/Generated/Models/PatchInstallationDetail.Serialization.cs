// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class PatchInstallationDetail : IUtf8JsonSerializable, IJsonModel<PatchInstallationDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatchInstallationDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PatchInstallationDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchInstallationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatchInstallationDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PatchId != null)
            {
                writer.WritePropertyName("patchId"u8);
                writer.WriteStringValue(PatchId);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && KbId != null)
            {
                writer.WritePropertyName("kbId"u8);
                writer.WriteStringValue(KbId);
            }
            if (options.Format != "W" && !(Classifications is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("classifications"u8);
                writer.WriteStartArray();
                foreach (var item in Classifications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && InstallationState.HasValue)
            {
                writer.WritePropertyName("installationState"u8);
                writer.WriteStringValue(InstallationState.Value.ToString());
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

        PatchInstallationDetail IJsonModel<PatchInstallationDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchInstallationDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatchInstallationDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatchInstallationDetail(document.RootElement, options);
        }

        internal static PatchInstallationDetail DeserializePatchInstallationDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string patchId = default;
            string name = default;
            string version = default;
            string kbId = default;
            IReadOnlyList<string> classifications = default;
            PatchInstallationState? installationState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchId"u8))
                {
                    patchId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kbId"u8))
                {
                    kbId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classifications"u8))
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
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("installationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installationState = new PatchInstallationState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PatchInstallationDetail(
                patchId,
                name,
                version,
                kbId,
                classifications ?? new ChangeTrackingList<string>(),
                installationState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatchInstallationDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchInstallationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatchInstallationDetail)} does not support '{options.Format}' format.");
            }
        }

        PatchInstallationDetail IPersistableModel<PatchInstallationDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchInstallationDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatchInstallationDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatchInstallationDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatchInstallationDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
