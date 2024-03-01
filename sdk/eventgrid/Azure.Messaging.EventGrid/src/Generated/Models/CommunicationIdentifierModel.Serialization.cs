// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class CommunicationIdentifierModel
    {
        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rawId = default;
            CommunicationUserIdentifierModel communicationUser = default;
            PhoneNumberIdentifierModel phoneNumber = default;
            MicrosoftTeamsUserIdentifierModel microsoftTeamsUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawId"u8))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phoneNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsUser = MicrosoftTeamsUserIdentifierModel.DeserializeMicrosoftTeamsUserIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentifierModel(rawId, communicationUser, phoneNumber, microsoftTeamsUser);
        }
    }
}
