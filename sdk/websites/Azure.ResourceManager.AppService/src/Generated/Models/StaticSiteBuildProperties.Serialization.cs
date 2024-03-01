// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteBuildProperties : IUtf8JsonSerializable, IJsonModel<StaticSiteBuildProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteBuildProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StaticSiteBuildProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AppLocation != null)
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation);
            }
            if (ApiLocation != null)
            {
                writer.WritePropertyName("apiLocation"u8);
                writer.WriteStringValue(ApiLocation);
            }
            if (AppArtifactLocation != null)
            {
                writer.WritePropertyName("appArtifactLocation"u8);
                writer.WriteStringValue(AppArtifactLocation);
            }
            if (OutputLocation != null)
            {
                writer.WritePropertyName("outputLocation"u8);
                writer.WriteStringValue(OutputLocation);
            }
            if (AppBuildCommand != null)
            {
                writer.WritePropertyName("appBuildCommand"u8);
                writer.WriteStringValue(AppBuildCommand);
            }
            if (ApiBuildCommand != null)
            {
                writer.WritePropertyName("apiBuildCommand"u8);
                writer.WriteStringValue(ApiBuildCommand);
            }
            if (SkipGithubActionWorkflowGeneration.HasValue)
            {
                writer.WritePropertyName("skipGithubActionWorkflowGeneration"u8);
                writer.WriteBooleanValue(SkipGithubActionWorkflowGeneration.Value);
            }
            if (GithubActionSecretNameOverride != null)
            {
                writer.WritePropertyName("githubActionSecretNameOverride"u8);
                writer.WriteStringValue(GithubActionSecretNameOverride);
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

        StaticSiteBuildProperties IJsonModel<StaticSiteBuildProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteBuildProperties(document.RootElement, options);
        }

        internal static StaticSiteBuildProperties DeserializeStaticSiteBuildProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string appLocation = default;
            string apiLocation = default;
            string appArtifactLocation = default;
            string outputLocation = default;
            string appBuildCommand = default;
            string apiBuildCommand = default;
            bool? skipGithubActionWorkflowGeneration = default;
            string githubActionSecretNameOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiLocation"u8))
                {
                    apiLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appArtifactLocation"u8))
                {
                    appArtifactLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputLocation"u8))
                {
                    outputLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appBuildCommand"u8))
                {
                    appBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiBuildCommand"u8))
                {
                    apiBuildCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skipGithubActionWorkflowGeneration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipGithubActionWorkflowGeneration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("githubActionSecretNameOverride"u8))
                {
                    githubActionSecretNameOverride = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StaticSiteBuildProperties(
                appLocation,
                apiLocation,
                appArtifactLocation,
                outputLocation,
                appBuildCommand,
                apiBuildCommand,
                skipGithubActionWorkflowGeneration,
                githubActionSecretNameOverride,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticSiteBuildProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support '{options.Format}' format.");
            }
        }

        StaticSiteBuildProperties IPersistableModel<StaticSiteBuildProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSiteBuildProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteBuildProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
