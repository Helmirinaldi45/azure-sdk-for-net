// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class StorageSyncWorkflowData : IUtf8JsonSerializable, IJsonModel<StorageSyncWorkflowData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncWorkflowData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncWorkflowData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncWorkflowData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncWorkflowData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (LastStepName != null)
            {
                writer.WritePropertyName("lastStepName"u8);
                writer.WriteStringValue(LastStepName);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Operation.HasValue)
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation.Value.ToString());
            }
            if (Steps != null)
            {
                writer.WritePropertyName("steps"u8);
                writer.WriteStringValue(Steps);
            }
            if (LastOperationId.HasValue)
            {
                writer.WritePropertyName("lastOperationId"u8);
                writer.WriteStringValue(LastOperationId.Value);
            }
            if (options.Format != "W" && CommandName != null)
            {
                writer.WritePropertyName("commandName"u8);
                writer.WriteStringValue(CommandName);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdTimestamp"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && LastStatusUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastStatusTimestamp"u8);
                writer.WriteStringValue(LastStatusUpdatedOn.Value, "O");
            }
            writer.WriteEndObject();
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

        StorageSyncWorkflowData IJsonModel<StorageSyncWorkflowData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncWorkflowData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncWorkflowData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncWorkflowData(document.RootElement, options);
        }

        internal static StorageSyncWorkflowData DeserializeStorageSyncWorkflowData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string lastStepName = default;
            StorageSyncWorkflowStatus? status = default;
            StorageSyncOperationDirection? operation = default;
            string steps = default;
            Guid? lastOperationId = default;
            string commandName = default;
            DateTimeOffset? createdTimestamp = default;
            DateTimeOffset? lastStatusTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("lastStepName"u8))
                        {
                            lastStepName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new StorageSyncWorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operation = new StorageSyncOperationDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("steps"u8))
                        {
                            steps = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOperationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("commandName"u8))
                        {
                            commandName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastStatusTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSyncWorkflowData(
                id,
                name,
                type,
                systemData,
                lastStepName,
                status,
                operation,
                steps,
                lastOperationId,
                commandName,
                createdTimestamp,
                lastStatusTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncWorkflowData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncWorkflowData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncWorkflowData)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncWorkflowData IPersistableModel<StorageSyncWorkflowData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncWorkflowData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncWorkflowData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncWorkflowData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncWorkflowData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
