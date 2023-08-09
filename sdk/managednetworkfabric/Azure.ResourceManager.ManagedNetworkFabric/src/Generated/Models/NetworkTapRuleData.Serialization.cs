// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkTapRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(ConfigurationType))
            {
                writer.WritePropertyName("configurationType"u8);
                writer.WriteStringValue(ConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(TapRulesUri))
            {
                writer.WritePropertyName("tapRulesUrl"u8);
                writer.WriteStringValue(TapRulesUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(MatchConfigurations))
            {
                writer.WritePropertyName("matchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DynamicMatchConfigurations))
            {
                writer.WritePropertyName("dynamicMatchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in DynamicMatchConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PollingIntervalInSeconds))
            {
                writer.WritePropertyName("pollingIntervalInSeconds"u8);
                writer.WriteNumberValue(PollingIntervalInSeconds.Value.ToSerialInt32());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkTapRuleData DeserializeNetworkTapRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<NetworkFabricConfigurationType> configurationType = default;
            Optional<Uri> tapRulesUrl = default;
            Optional<IList<NetworkTapRuleMatchConfiguration>> matchConfigurations = default;
            Optional<IList<CommonDynamicMatchConfiguration>> dynamicMatchConfigurations = default;
            Optional<ResourceIdentifier> networkTapId = default;
            Optional<PollingIntervalInSecond> pollingIntervalInSeconds = default;
            Optional<DateTimeOffset> lastSyncedTime = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationType = new NetworkFabricConfigurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tapRulesUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tapRulesUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("matchConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkTapRuleMatchConfiguration> array = new List<NetworkTapRuleMatchConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkTapRuleMatchConfiguration.DeserializeNetworkTapRuleMatchConfiguration(item));
                            }
                            matchConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dynamicMatchConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CommonDynamicMatchConfiguration> array = new List<CommonDynamicMatchConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CommonDynamicMatchConfiguration.DeserializeCommonDynamicMatchConfiguration(item));
                            }
                            dynamicMatchConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("networkTapId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkTapId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pollingIntervalInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pollingIntervalInSeconds = new PollingIntervalInSecond(property0.Value.GetInt32());
                            continue;
                        }
                        if (property0.NameEquals("lastSyncedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSyncedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkTapRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, annotation.Value, Optional.ToNullable(configurationType), tapRulesUrl.Value, Optional.ToList(matchConfigurations), Optional.ToList(dynamicMatchConfigurations), networkTapId.Value, Optional.ToNullable(pollingIntervalInSeconds), Optional.ToNullable(lastSyncedTime), Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState));
        }
    }
}
