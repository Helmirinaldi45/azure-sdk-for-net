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
    public partial class ServerEndpointRecallStatus : IUtf8JsonSerializable, IJsonModel<ServerEndpointRecallStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEndpointRecallStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerEndpointRecallStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointRecallStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointRecallStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && TotalRecallErrorsCount.HasValue)
            {
                writer.WritePropertyName("totalRecallErrorsCount"u8);
                writer.WriteNumberValue(TotalRecallErrorsCount.Value);
            }
            if (options.Format != "W" && !(RecallErrors is ChangeTrackingList<ServerEndpointRecallError> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("recallErrors"u8);
                writer.WriteStartArray();
                foreach (var item in RecallErrors)
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

        ServerEndpointRecallStatus IJsonModel<ServerEndpointRecallStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointRecallStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointRecallStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointRecallStatus(document.RootElement, options);
        }

        internal static ServerEndpointRecallStatus DeserializeServerEndpointRecallStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            long? totalRecallErrorsCount = default;
            IReadOnlyList<ServerEndpointRecallError> recallErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalRecallErrorsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalRecallErrorsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recallErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServerEndpointRecallError> array = new List<ServerEndpointRecallError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerEndpointRecallError.DeserializeServerEndpointRecallError(item, options));
                    }
                    recallErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerEndpointRecallStatus(lastUpdatedTimestamp, totalRecallErrorsCount, recallErrors ?? new ChangeTrackingList<ServerEndpointRecallError>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEndpointRecallStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointRecallStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointRecallStatus)} does not support '{options.Format}' format.");
            }
        }

        ServerEndpointRecallStatus IPersistableModel<ServerEndpointRecallStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointRecallStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerEndpointRecallStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointRecallStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointRecallStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
