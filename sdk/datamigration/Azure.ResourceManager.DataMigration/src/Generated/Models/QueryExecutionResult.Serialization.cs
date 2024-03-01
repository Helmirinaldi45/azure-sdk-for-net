// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QueryExecutionResult : IUtf8JsonSerializable, IJsonModel<QueryExecutionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryExecutionResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryExecutionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryExecutionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryExecutionResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueryText != null)
            {
                writer.WritePropertyName("queryText"u8);
                writer.WriteStringValue(QueryText);
            }
            if (StatementsInBatch.HasValue)
            {
                writer.WritePropertyName("statementsInBatch"u8);
                writer.WriteNumberValue(StatementsInBatch.Value);
            }
            if (SourceResult != null)
            {
                writer.WritePropertyName("sourceResult"u8);
                writer.WriteObjectValue(SourceResult);
            }
            if (TargetResult != null)
            {
                writer.WritePropertyName("targetResult"u8);
                writer.WriteObjectValue(TargetResult);
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

        QueryExecutionResult IJsonModel<QueryExecutionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryExecutionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryExecutionResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryExecutionResult(document.RootElement, options);
        }

        internal static QueryExecutionResult DeserializeQueryExecutionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queryText = default;
            long? statementsInBatch = default;
            ExecutionStatistics sourceResult = default;
            ExecutionStatistics targetResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryText"u8))
                {
                    queryText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementsInBatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementsInBatch = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryExecutionResult(queryText, statementsInBatch, sourceResult, targetResult, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryExecutionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryExecutionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryExecutionResult)} does not support '{options.Format}' format.");
            }
        }

        QueryExecutionResult IPersistableModel<QueryExecutionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryExecutionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryExecutionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryExecutionResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryExecutionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
