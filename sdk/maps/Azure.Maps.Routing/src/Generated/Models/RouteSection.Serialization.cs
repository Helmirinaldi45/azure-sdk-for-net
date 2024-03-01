// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteSection
    {
        internal static RouteSection DeserializeRouteSection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? startPointIndex = default;
            int? endPointIndex = default;
            ResponseSectionType? sectionType = default;
            ResponseTravelMode? travelMode = default;
            TrafficIncidentCategory? simpleCategory = default;
            int? effectiveSpeedInKmh = default;
            int? delayInSeconds = default;
            DelayMagnitude? magnitudeOfDelay = default;
            RouteSectionTec tec = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startPointIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startPointIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endPointIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endPointIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sectionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sectionType = new ResponseSectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("travelMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    travelMode = new ResponseTravelMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("simpleCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    simpleCategory = new TrafficIncidentCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("effectiveSpeedInKmh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveSpeedInKmh = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("delayInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("magnitudeOfDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    magnitudeOfDelay = new DelayMagnitude(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tec = RouteSectionTec.DeserializeRouteSectionTec(property.Value);
                    continue;
                }
            }
            return new RouteSection(
                startPointIndex,
                endPointIndex,
                sectionType,
                travelMode,
                simpleCategory,
                effectiveSpeedInKmh,
                delayInSeconds,
                magnitudeOfDelay,
                tec);
        }
    }
}
