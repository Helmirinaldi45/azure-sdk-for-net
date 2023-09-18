// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterPoolVersionValue))
            {
                writer.WritePropertyName("clusterPoolVersion"u8);
                writer.WriteStringValue(ClusterPoolVersionValue);
            }
            if (Optional.IsDefined(AksVersion))
            {
                writer.WritePropertyName("aksVersion"u8);
                writer.WriteStringValue(AksVersion);
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ClusterPoolVersion DeserializeClusterPoolVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> clusterPoolVersion = default;
            Optional<string> aksVersion = default;
            Optional<bool> isPreview = default;
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
                        if (property0.NameEquals("clusterPoolVersion"u8))
                        {
                            clusterPoolVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aksVersion"u8))
                        {
                            aksVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isPreview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPreview = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterPoolVersion(id, name, type, systemData.Value, clusterPoolVersion.Value, aksVersion.Value, Optional.ToNullable(isPreview));
        }
    }
}
