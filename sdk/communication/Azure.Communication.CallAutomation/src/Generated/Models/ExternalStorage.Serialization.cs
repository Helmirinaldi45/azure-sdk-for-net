// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class ExternalStorage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recordingStorageKind"u8);
            writer.WriteStringValue(RecordingStorageKind.ToString());
            if (RecordingDestinationContainerUri != null)
            {
                writer.WritePropertyName("recordingDestinationContainerUrl"u8);
                writer.WriteStringValue(RecordingDestinationContainerUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }
    }
}
