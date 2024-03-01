// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoAuthInfoUpdateContent : IUtf8JsonSerializable, IJsonModel<SourceCodeRepoAuthInfoUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceCodeRepoAuthInfoUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceCodeRepoAuthInfoUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoAuthInfoUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TokenType.HasValue)
            {
                writer.WritePropertyName("tokenType"u8);
                writer.WriteStringValue(TokenType.Value.ToString());
            }
            if (Token != null)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (RefreshToken != null)
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (ExpiresIn.HasValue)
            {
                writer.WritePropertyName("expiresIn"u8);
                writer.WriteNumberValue(ExpiresIn.Value);
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

        SourceCodeRepoAuthInfoUpdateContent IJsonModel<SourceCodeRepoAuthInfoUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoAuthInfoUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoAuthInfoUpdateContent(document.RootElement, options);
        }

        internal static SourceCodeRepoAuthInfoUpdateContent DeserializeSourceCodeRepoAuthInfoUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoAuthTokenType? tokenType = default;
            string token = default;
            string refreshToken = default;
            string scope = default;
            int? expiresIn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenType = new SourceCodeRepoAuthTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceCodeRepoAuthInfoUpdateContent(
                tokenType,
                token,
                refreshToken,
                scope,
                expiresIn,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoAuthInfoUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        SourceCodeRepoAuthInfoUpdateContent IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceCodeRepoAuthInfoUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoAuthInfoUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceCodeRepoAuthInfoUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
