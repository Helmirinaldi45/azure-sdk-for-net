// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionCreditSummary : IUtf8JsonSerializable, IJsonModel<ConsumptionCreditSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionCreditSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionCreditSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionCreditSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionCreditSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ETag.HasValue)
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (options.Format != "W" && BalanceSummary != null)
            {
                writer.WritePropertyName("balanceSummary"u8);
                writer.WriteObjectValue(BalanceSummary);
            }
            if (options.Format != "W" && PendingCreditAdjustments != null)
            {
                writer.WritePropertyName("pendingCreditAdjustments"u8);
                writer.WriteObjectValue(PendingCreditAdjustments);
            }
            if (options.Format != "W" && ExpiredCredit != null)
            {
                writer.WritePropertyName("expiredCredit"u8);
                writer.WriteObjectValue(ExpiredCredit);
            }
            if (options.Format != "W" && PendingEligibleCharges != null)
            {
                writer.WritePropertyName("pendingEligibleCharges"u8);
                writer.WriteObjectValue(PendingEligibleCharges);
            }
            if (options.Format != "W" && CreditCurrency != null)
            {
                writer.WritePropertyName("creditCurrency"u8);
                writer.WriteStringValue(CreditCurrency);
            }
            if (options.Format != "W" && BillingCurrency != null)
            {
                writer.WritePropertyName("billingCurrency"u8);
                writer.WriteStringValue(BillingCurrency);
            }
            if (options.Format != "W" && Reseller != null)
            {
                writer.WritePropertyName("reseller"u8);
                writer.WriteObjectValue(Reseller);
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

        ConsumptionCreditSummary IJsonModel<ConsumptionCreditSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionCreditSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionCreditSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionCreditSummary(document.RootElement, options);
        }

        internal static ConsumptionCreditSummary DeserializeConsumptionCreditSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            CreditBalanceSummary balanceSummary = default;
            ConsumptionAmount pendingCreditAdjustments = default;
            ConsumptionAmount expiredCredit = default;
            ConsumptionAmount pendingEligibleCharges = default;
            string creditCurrency = default;
            string billingCurrency = default;
            ConsumptionReseller reseller = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("balanceSummary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            balanceSummary = CreditBalanceSummary.DeserializeCreditBalanceSummary(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("pendingCreditAdjustments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pendingCreditAdjustments = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("expiredCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiredCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("pendingEligibleCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pendingEligibleCharges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("creditCurrency"u8))
                        {
                            creditCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = ConsumptionReseller.DeserializeConsumptionReseller(property0.Value, options);
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
            return new ConsumptionCreditSummary(
                id,
                name,
                type,
                systemData,
                balanceSummary,
                pendingCreditAdjustments,
                expiredCredit,
                pendingEligibleCharges,
                creditCurrency,
                billingCurrency,
                reseller,
                eTag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionCreditSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionCreditSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionCreditSummary)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionCreditSummary IPersistableModel<ConsumptionCreditSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionCreditSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionCreditSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionCreditSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionCreditSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
