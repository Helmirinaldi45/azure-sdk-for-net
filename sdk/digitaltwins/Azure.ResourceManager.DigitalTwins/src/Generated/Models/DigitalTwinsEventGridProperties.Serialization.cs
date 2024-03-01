// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsEventGridProperties : IUtf8JsonSerializable, IJsonModel<DigitalTwinsEventGridProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigitalTwinsEventGridProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DigitalTwinsEventGridProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEventGridProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEventGridProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("TopicEndpoint"u8);
            writer.WriteStringValue(TopicEndpoint);
            if (AccessKey1 != null)
            {
                writer.WritePropertyName("accessKey1"u8);
                writer.WriteStringValue(AccessKey1);
            }
            else
            {
                writer.WriteNull("accessKey1");
            }
            if (AccessKey2 != null)
            {
                if (AccessKey2 != null)
                {
                    writer.WritePropertyName("accessKey2"u8);
                    writer.WriteStringValue(AccessKey2);
                }
                else
                {
                    writer.WriteNull("accessKey2");
                }
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                if (ProvisioningState != null)
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
                else
                {
                    writer.WriteNull("provisioningState");
                }
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                if (CreatedOn != null)
                {
                    writer.WritePropertyName("createdTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("createdTime");
                }
            }
            if (AuthenticationType.HasValue)
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (DeadLetterSecret != null)
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (DeadLetterUri != null)
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Identity != null)
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        DigitalTwinsEventGridProperties IJsonModel<DigitalTwinsEventGridProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEventGridProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigitalTwinsEventGridProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEventGridProperties(document.RootElement, options);
        }

        internal static DigitalTwinsEventGridProperties DeserializeDigitalTwinsEventGridProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string topicEndpoint = default;
            string accessKey1 = default;
            string accessKey2 = default;
            EndpointType endpointType = default;
            DigitalTwinsEndpointProvisioningState? provisioningState = default;
            DateTimeOffset? createdTime = default;
            DigitalTwinsAuthenticationType? authenticationType = default;
            string deadLetterSecret = default;
            Uri deadLetterUri = default;
            DigitalTwinsManagedIdentityReference identity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("TopicEndpoint"u8))
                {
                    topicEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessKey1 = null;
                        continue;
                    }
                    accessKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accessKey2 = null;
                        continue;
                    }
                    accessKey2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DigitalTwinsEventGridProperties(
                endpointType,
                provisioningState,
                createdTime,
                authenticationType,
                deadLetterSecret,
                deadLetterUri,
                identity,
                serializedAdditionalRawData,
                topicEndpoint,
                accessKey1,
                accessKey2);
        }

        BinaryData IPersistableModel<DigitalTwinsEventGridProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEventGridProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEventGridProperties)} does not support '{options.Format}' format.");
            }
        }

        DigitalTwinsEventGridProperties IPersistableModel<DigitalTwinsEventGridProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigitalTwinsEventGridProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDigitalTwinsEventGridProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigitalTwinsEventGridProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigitalTwinsEventGridProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
