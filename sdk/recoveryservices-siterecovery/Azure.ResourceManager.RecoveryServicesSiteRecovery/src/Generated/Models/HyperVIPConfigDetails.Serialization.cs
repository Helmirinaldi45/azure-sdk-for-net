// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVIPConfigDetails : IUtf8JsonSerializable, IJsonModel<HyperVIPConfigDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVIPConfigDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVIPConfigDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVIPConfigDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (IsPrimary.HasValue)
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (SubnetName != null)
            {
                writer.WritePropertyName("subnetName"u8);
                writer.WriteStringValue(SubnetName);
            }
            if (StaticIPAddress != null)
            {
                writer.WritePropertyName("staticIPAddress"u8);
                writer.WriteStringValue(StaticIPAddress.ToString());
            }
            if (IPAddressType != null)
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType);
            }
            if (IsSeletedForFailover.HasValue)
            {
                writer.WritePropertyName("isSeletedForFailover"u8);
                writer.WriteBooleanValue(IsSeletedForFailover.Value);
            }
            if (RecoverySubnetName != null)
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
            if (RecoveryStaticIPAddress != null)
            {
                writer.WritePropertyName("recoveryStaticIPAddress"u8);
                writer.WriteStringValue(RecoveryStaticIPAddress.ToString());
            }
            if (RecoveryIPAddressType != null)
            {
                writer.WritePropertyName("recoveryIPAddressType"u8);
                writer.WriteStringValue(RecoveryIPAddressType);
            }
            if (RecoveryPublicIPAddressId != null)
            {
                writer.WritePropertyName("recoveryPublicIPAddressId"u8);
                writer.WriteStringValue(RecoveryPublicIPAddressId);
            }
            if (!(RecoveryLBBackendAddressPoolIds is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("recoveryLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (TfoSubnetName != null)
            {
                writer.WritePropertyName("tfoSubnetName"u8);
                writer.WriteStringValue(TfoSubnetName);
            }
            if (TfoStaticIPAddress != null)
            {
                writer.WritePropertyName("tfoStaticIPAddress"u8);
                writer.WriteStringValue(TfoStaticIPAddress.ToString());
            }
            if (TfoPublicIPAddressId != null)
            {
                writer.WritePropertyName("tfoPublicIPAddressId"u8);
                writer.WriteStringValue(TfoPublicIPAddressId);
            }
            if (!(TfoLBBackendAddressPoolIds is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("tfoLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in TfoLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
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

        HyperVIPConfigDetails IJsonModel<HyperVIPConfigDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVIPConfigDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVIPConfigDetails(document.RootElement, options);
        }

        internal static HyperVIPConfigDetails DeserializeHyperVIPConfigDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            bool? isPrimary = default;
            string subnetName = default;
            IPAddress staticIPAddress = default;
            string ipAddressType = default;
            bool? isSeletedForFailover = default;
            string recoverySubnetName = default;
            IPAddress recoveryStaticIPAddress = default;
            string recoveryIPAddressType = default;
            ResourceIdentifier recoveryPublicIPAddressId = default;
            IReadOnlyList<string> recoveryLBBackendAddressPoolIds = default;
            string tfoSubnetName = default;
            IPAddress tfoStaticIPAddress = default;
            ResourceIdentifier tfoPublicIPAddressId = default;
            IReadOnlyList<string> tfoLBBackendAddressPoolIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subnetName"u8))
                {
                    subnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("staticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    ipAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSeletedForFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSeletedForFailover = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoverySubnetName"u8))
                {
                    recoverySubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryIPAddressType"u8))
                {
                    recoveryIPAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPublicIPAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPublicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryLBBackendAddressPoolIds"u8))
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
                    recoveryLBBackendAddressPoolIds = array;
                    continue;
                }
                if (property.NameEquals("tfoSubnetName"u8))
                {
                    tfoSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tfoPublicIPAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoPublicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tfoLBBackendAddressPoolIds"u8))
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
                    tfoLBBackendAddressPoolIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVIPConfigDetails(
                name,
                isPrimary,
                subnetName,
                staticIPAddress,
                ipAddressType,
                isSeletedForFailover,
                recoverySubnetName,
                recoveryStaticIPAddress,
                recoveryIPAddressType,
                recoveryPublicIPAddressId,
                recoveryLBBackendAddressPoolIds ?? new ChangeTrackingList<string>(),
                tfoSubnetName,
                tfoStaticIPAddress,
                tfoPublicIPAddressId,
                tfoLBBackendAddressPoolIds ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HyperVIPConfigDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVIPConfigDetails)} does not support '{options.Format}' format.");
            }
        }

        HyperVIPConfigDetails IPersistableModel<HyperVIPConfigDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVIPConfigDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVIPConfigDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVIPConfigDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
