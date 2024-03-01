// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlMetricDefinition : IUtf8JsonSerializable, IJsonModel<SqlMetricDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlMetricDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlMetricDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (options.Format != "W" && PrimaryAggregationType.HasValue)
            {
                writer.WritePropertyName("primaryAggregationType"u8);
                writer.WriteStringValue(PrimaryAggregationType.Value.ToString());
            }
            if (options.Format != "W" && ResourceUriString != null)
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUriString);
            }
            if (options.Format != "W" && Unit.HasValue)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && !(MetricAvailabilities is ChangeTrackingList<SqlMetricAvailability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metricAvailabilities"u8);
                writer.WriteStartArray();
                foreach (var item in MetricAvailabilities)
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

        SqlMetricDefinition IJsonModel<SqlMetricDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlMetricDefinition(document.RootElement, options);
        }

        internal static SqlMetricDefinition DeserializeSqlMetricDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlMetricName name = default;
            SqlMetricPrimaryAggregationType? primaryAggregationType = default;
            string resourceUri = default;
            SqlMetricDefinitionUnitType? unit = default;
            IReadOnlyList<SqlMetricAvailability> metricAvailabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = SqlMetricName.DeserializeSqlMetricName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryAggregationType = new SqlMetricPrimaryAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new SqlMetricDefinitionUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlMetricAvailability> array = new List<SqlMetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlMetricAvailability.DeserializeSqlMetricAvailability(item, options));
                    }
                    metricAvailabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlMetricDefinition(
                name,
                primaryAggregationType,
                resourceUri,
                unit,
                metricAvailabilities ?? new ChangeTrackingList<SqlMetricAvailability>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlMetricDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        SqlMetricDefinition IPersistableModel<SqlMetricDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlMetricDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlMetricDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlMetricDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
