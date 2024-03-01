// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class SiteNetworkServicePropertiesFormat : IUtf8JsonSerializable, IJsonModel<SiteNetworkServicePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteNetworkServicePropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteNetworkServicePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteNetworkServicePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteNetworkServicePropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (ManagedResourceGroupConfiguration != null)
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (SiteReference != null)
            {
                writer.WritePropertyName("siteReference"u8);
                JsonSerializer.Serialize(writer, SiteReference);
            }
            if (options.Format != "W" && PublisherName != null)
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && PublisherScope.HasValue)
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && NetworkServiceDesignGroupName != null)
            {
                writer.WritePropertyName("networkServiceDesignGroupName"u8);
                writer.WriteStringValue(NetworkServiceDesignGroupName);
            }
            if (options.Format != "W" && NetworkServiceDesignVersionName != null)
            {
                writer.WritePropertyName("networkServiceDesignVersionName"u8);
                writer.WriteStringValue(NetworkServiceDesignVersionName);
            }
            if (options.Format != "W" && NetworkServiceDesignVersionOfferingLocation != null)
            {
                writer.WritePropertyName("networkServiceDesignVersionOfferingLocation"u8);
                writer.WriteStringValue(NetworkServiceDesignVersionOfferingLocation);
            }
            if (NetworkServiceDesignVersionResourceReference != null)
            {
                writer.WritePropertyName("networkServiceDesignVersionResourceReference"u8);
                writer.WriteObjectValue(NetworkServiceDesignVersionResourceReference);
            }
            if (!(DesiredStateConfigurationGroupValueReferences is ChangeTrackingDictionary<string, WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("desiredStateConfigurationGroupValueReferences"u8);
                writer.WriteStartObject();
                foreach (var item in DesiredStateConfigurationGroupValueReferences)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && LastStateNetworkServiceDesignVersionName != null)
            {
                writer.WritePropertyName("lastStateNetworkServiceDesignVersionName"u8);
                writer.WriteStringValue(LastStateNetworkServiceDesignVersionName);
            }
            if (options.Format != "W" && !(LastStateConfigurationGroupValueReferences is ChangeTrackingDictionary<string, WritableSubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("lastStateConfigurationGroupValueReferences"u8);
                writer.WriteStartObject();
                foreach (var item in LastStateConfigurationGroupValueReferences)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
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

        SiteNetworkServicePropertiesFormat IJsonModel<SiteNetworkServicePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteNetworkServicePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteNetworkServicePropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteNetworkServicePropertiesFormat(document.RootElement, options);
        }

        internal static SiteNetworkServicePropertiesFormat DeserializeSiteNetworkServicePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            ManagedResourceGroupConfiguration managedResourceGroupConfiguration = default;
            WritableSubResource siteReference = default;
            string publisherName = default;
            PublisherScope? publisherScope = default;
            string networkServiceDesignGroupName = default;
            string networkServiceDesignVersionName = default;
            string networkServiceDesignVersionOfferingLocation = default;
            DeploymentResourceIdReference networkServiceDesignVersionResourceReference = default;
            IDictionary<string, WritableSubResource> desiredStateConfigurationGroupValueReferences = default;
            string lastStateNetworkServiceDesignVersionName = default;
            IReadOnlyDictionary<string, WritableSubResource> lastStateConfigurationGroupValueReferences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceGroupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("siteReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkServiceDesignGroupName"u8))
                {
                    networkServiceDesignGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionName"u8))
                {
                    networkServiceDesignVersionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionOfferingLocation"u8))
                {
                    networkServiceDesignVersionOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkServiceDesignVersionResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkServiceDesignVersionResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("desiredStateConfigurationGroupValueReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText()));
                    }
                    desiredStateConfigurationGroupValueReferences = dictionary;
                    continue;
                }
                if (property.NameEquals("lastStateNetworkServiceDesignVersionName"u8))
                {
                    lastStateNetworkServiceDesignVersionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastStateConfigurationGroupValueReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText()));
                    }
                    lastStateConfigurationGroupValueReferences = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteNetworkServicePropertiesFormat(
                provisioningState,
                managedResourceGroupConfiguration,
                siteReference,
                publisherName,
                publisherScope,
                networkServiceDesignGroupName,
                networkServiceDesignVersionName,
                networkServiceDesignVersionOfferingLocation,
                networkServiceDesignVersionResourceReference,
                desiredStateConfigurationGroupValueReferences ?? new ChangeTrackingDictionary<string, WritableSubResource>(),
                lastStateNetworkServiceDesignVersionName,
                lastStateConfigurationGroupValueReferences ?? new ChangeTrackingDictionary<string, WritableSubResource>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteNetworkServicePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteNetworkServicePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteNetworkServicePropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        SiteNetworkServicePropertiesFormat IPersistableModel<SiteNetworkServicePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteNetworkServicePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteNetworkServicePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteNetworkServicePropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteNetworkServicePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
