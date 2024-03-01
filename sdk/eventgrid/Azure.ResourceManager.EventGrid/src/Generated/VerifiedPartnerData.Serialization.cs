// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class VerifiedPartnerData : IUtf8JsonSerializable, IJsonModel<VerifiedPartnerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VerifiedPartnerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VerifiedPartnerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifiedPartnerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VerifiedPartnerData)} does not support '{format}' format.");
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
            if (PartnerRegistrationImmutableId.HasValue)
            {
                writer.WritePropertyName("partnerRegistrationImmutableId"u8);
                writer.WriteStringValue(PartnerRegistrationImmutableId.Value);
            }
            if (OrganizationName != null)
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteStringValue(OrganizationName);
            }
            if (PartnerDisplayName != null)
            {
                writer.WritePropertyName("partnerDisplayName"u8);
                writer.WriteStringValue(PartnerDisplayName);
            }
            if (PartnerTopicDetails != null)
            {
                writer.WritePropertyName("partnerTopicDetails"u8);
                writer.WriteObjectValue(PartnerTopicDetails);
            }
            if (PartnerDestinationDetails != null)
            {
                writer.WritePropertyName("partnerDestinationDetails"u8);
                writer.WriteObjectValue(PartnerDestinationDetails);
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        VerifiedPartnerData IJsonModel<VerifiedPartnerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifiedPartnerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VerifiedPartnerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVerifiedPartnerData(document.RootElement, options);
        }

        internal static VerifiedPartnerData DeserializeVerifiedPartnerData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Guid? partnerRegistrationImmutableId = default;
            string organizationName = default;
            string partnerDisplayName = default;
            PartnerDetails partnerTopicDetails = default;
            PartnerDetails partnerDestinationDetails = default;
            VerifiedPartnerProvisioningState? provisioningState = default;
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
                        if (property0.NameEquals("partnerRegistrationImmutableId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRegistrationImmutableId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("organizationName"u8))
                        {
                            organizationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDisplayName"u8))
                        {
                            partnerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicDetails = PartnerDetails.DeserializePartnerDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("partnerDestinationDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerDestinationDetails = PartnerDetails.DeserializePartnerDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VerifiedPartnerProvisioningState(property0.Value.GetString());
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
            return new VerifiedPartnerData(
                id,
                name,
                type,
                systemData,
                partnerRegistrationImmutableId,
                organizationName,
                partnerDisplayName,
                partnerTopicDetails,
                partnerDestinationDetails,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VerifiedPartnerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifiedPartnerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VerifiedPartnerData)} does not support '{options.Format}' format.");
            }
        }

        VerifiedPartnerData IPersistableModel<VerifiedPartnerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifiedPartnerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVerifiedPartnerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VerifiedPartnerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VerifiedPartnerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
