// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class KeyValuePair
    {
        internal static KeyValuePair DeserializeKeyValuePair(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string label = default;
            KeyValueElement key = default;
            KeyValueElement value = default;
            float confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = KeyValueElement.DeserializeKeyValueElement(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = KeyValueElement.DeserializeKeyValueElement(property.Value);
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return new KeyValuePair(label, key, value, confidence);
        }
    }
}
