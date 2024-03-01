// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeRegistrationProperties : IUtf8JsonSerializable, IJsonModel<ResourceTypeRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeRegistrationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceTypeRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceTypeRegistrationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RoutingType.HasValue)
            {
                writer.WritePropertyName("routingType"u8);
                writer.WriteStringValue(RoutingType.Value.ToString());
            }
            if (Regionality.HasValue)
            {
                writer.WritePropertyName("regionality"u8);
                writer.WriteStringValue(Regionality.Value.ToString());
            }
            if (!(Endpoints is ChangeTrackingList<ResourceTypeEndpoint> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ExtensionOptions != null)
            {
                writer.WritePropertyName("extensionOptions"u8);
                writer.WriteObjectValue(ExtensionOptions);
            }
            if (MarketplaceType.HasValue)
            {
                writer.WritePropertyName("marketplaceType"u8);
                writer.WriteStringValue(MarketplaceType.Value.ToSerialString());
            }
            if (!(SwaggerSpecifications is ChangeTrackingList<SwaggerSpecification> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("swaggerSpecifications"u8);
                writer.WriteStartArray();
                foreach (var item in SwaggerSpecifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AllowedUnauthorizedActions is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("allowedUnauthorizedActions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnauthorizedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AuthorizationActionMappings is ChangeTrackingList<AuthorizationActionMapping> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("authorizationActionMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationActionMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LinkedAccessChecks is ChangeTrackingList<LinkedAccessCheck> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("linkedAccessChecks"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedAccessChecks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultApiVersion != null)
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (!(LoggingRules is ChangeTrackingList<LoggingRule> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("loggingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoggingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ThrottlingRules is ChangeTrackingList<ThrottlingRule> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("throttlingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ThrottlingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(RequiredFeatures is ChangeTrackingList<string> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (FeaturesRule != null)
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (IsAsyncOperationEnabled.HasValue)
            {
                writer.WritePropertyName("enableAsyncOperation"u8);
                writer.WriteBooleanValue(IsAsyncOperationEnabled.Value);
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (IsThirdPartyS2SEnabled.HasValue)
            {
                writer.WritePropertyName("enableThirdPartyS2S"u8);
                writer.WriteBooleanValue(IsThirdPartyS2SEnabled.Value);
            }
            if (SubscriptionLifecycleNotificationSpecifications != null)
            {
                writer.WritePropertyName("subscriptionLifecycleNotificationSpecifications"u8);
                writer.WriteObjectValue(SubscriptionLifecycleNotificationSpecifications);
            }
            if (IsPureProxy.HasValue)
            {
                writer.WritePropertyName("isPureProxy"u8);
                writer.WriteBooleanValue(IsPureProxy.Value);
            }
            if (IdentityManagement != null)
            {
                writer.WritePropertyName("identityManagement"u8);
                writer.WriteObjectValue(IdentityManagement);
            }
            if (CheckNameAvailabilitySpecifications != null)
            {
                writer.WritePropertyName("checkNameAvailabilitySpecifications"u8);
                writer.WriteObjectValue(CheckNameAvailabilitySpecifications);
            }
            if (!(DisallowedActionVerbs is ChangeTrackingList<string> collection7 && collection7.IsUndefined))
            {
                writer.WritePropertyName("disallowedActionVerbs"u8);
                writer.WriteStartArray();
                foreach (var item in DisallowedActionVerbs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceTreeInfos is ChangeTrackingList<ServiceTreeInfo> collection8 && collection8.IsUndefined))
            {
                writer.WritePropertyName("serviceTreeInfos"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequestHeaderOptions != null)
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (!(SubscriptionStateRules is ChangeTrackingList<ProviderSubscriptionStateRule> collection9 && collection9.IsUndefined))
            {
                writer.WritePropertyName("subscriptionStateRules"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionStateRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TemplateDeploymentOptions != null)
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions);
            }
            if (!(ExtendedLocations is ChangeTrackingList<ProviderHubExtendedLocationOptions> collection10 && collection10.IsUndefined))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceMovePolicy != null)
            {
                writer.WritePropertyName("resourceMovePolicy"u8);
                writer.WriteObjectValue(ResourceMovePolicy);
            }
            if (ResourceDeletionPolicy.HasValue)
            {
                writer.WritePropertyName("resourceDeletionPolicy"u8);
                writer.WriteStringValue(ResourceDeletionPolicy.Value.ToString());
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

        ResourceTypeRegistrationProperties IJsonModel<ResourceTypeRegistrationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceTypeRegistrationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeRegistrationProperties(document.RootElement, options);
        }

        internal static ResourceTypeRegistrationProperties DeserializeResourceTypeRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceRoutingType? routingType = default;
            ResourceTypeRegistrationRegionality? regionality = default;
            IList<ResourceTypeEndpoint> endpoints = default;
            ResourceTypeExtensionOptions extensionOptions = default;
            MarketplaceType? marketplaceType = default;
            IList<SwaggerSpecification> swaggerSpecifications = default;
            IList<string> allowedUnauthorizedActions = default;
            IList<AuthorizationActionMapping> authorizationActionMappings = default;
            IList<LinkedAccessCheck> linkedAccessChecks = default;
            string defaultApiVersion = default;
            IList<LoggingRule> loggingRules = default;
            IList<ThrottlingRule> throttlingRules = default;
            IList<string> requiredFeatures = default;
            FeaturesRule featuresRule = default;
            bool? enableAsyncOperation = default;
            ProviderHubProvisioningState? provisioningState = default;
            bool? enableThirdPartyS2S = default;
            SubscriptionLifecycleNotificationSpecifications subscriptionLifecycleNotificationSpecifications = default;
            bool? isPureProxy = default;
            IdentityManagementProperties identityManagement = default;
            CheckNameAvailabilitySpecifications checkNameAvailabilitySpecifications = default;
            IList<string> disallowedActionVerbs = default;
            IList<ServiceTreeInfo> serviceTreeInfos = default;
            RequestHeaderOptions requestHeaderOptions = default;
            IList<ProviderSubscriptionStateRule> subscriptionStateRules = default;
            TemplateDeploymentOptions templateDeploymentOptions = default;
            IList<ProviderHubExtendedLocationOptions> extendedLocations = default;
            ResourceMovePolicy resourceMovePolicy = default;
            ResourceDeletionPolicy? resourceDeletionPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingType = new ResourceRoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionality = new ResourceTypeRegistrationRegionality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeEndpoint> array = new List<ResourceTypeEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeEndpoint.DeserializeResourceTypeEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("extensionOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionOptions = ResourceTypeExtensionOptions.DeserializeResourceTypeExtensionOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("marketplaceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceType = property.Value.GetString().ToMarketplaceType();
                    continue;
                }
                if (property.NameEquals("swaggerSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SwaggerSpecification> array = new List<SwaggerSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SwaggerSpecification.DeserializeSwaggerSpecification(item, options));
                    }
                    swaggerSpecifications = array;
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"u8))
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
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item, options));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item, options));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item, options));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item, options));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableAsyncOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAsyncOperation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProviderHubProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableThirdPartyS2S"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableThirdPartyS2S = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionLifecycleNotificationSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionLifecycleNotificationSpecifications = SubscriptionLifecycleNotificationSpecifications.DeserializeSubscriptionLifecycleNotificationSpecifications(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isPureProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPureProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("identityManagement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityManagement = IdentityManagementProperties.DeserializeIdentityManagementProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("checkNameAvailabilitySpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkNameAvailabilitySpecifications = CheckNameAvailabilitySpecifications.DeserializeCheckNameAvailabilitySpecifications(property.Value, options);
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"u8))
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
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item, options));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderSubscriptionStateRule> array = new List<ProviderSubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderSubscriptionStateRule.DeserializeProviderSubscriptionStateRule(item, options));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentOptions = TemplateDeploymentOptions.DeserializeTemplateDeploymentOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderHubExtendedLocationOptions> array = new List<ProviderHubExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderHubExtendedLocationOptions.DeserializeProviderHubExtendedLocationOptions(item, options));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("resourceMovePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMovePolicy = ResourceMovePolicy.DeserializeResourceMovePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDeletionPolicy = new ResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceTypeRegistrationProperties(
                routingType,
                regionality,
                endpoints ?? new ChangeTrackingList<ResourceTypeEndpoint>(),
                extensionOptions,
                marketplaceType,
                swaggerSpecifications ?? new ChangeTrackingList<SwaggerSpecification>(),
                allowedUnauthorizedActions ?? new ChangeTrackingList<string>(),
                authorizationActionMappings ?? new ChangeTrackingList<AuthorizationActionMapping>(),
                linkedAccessChecks ?? new ChangeTrackingList<LinkedAccessCheck>(),
                defaultApiVersion,
                loggingRules ?? new ChangeTrackingList<LoggingRule>(),
                throttlingRules ?? new ChangeTrackingList<ThrottlingRule>(),
                requiredFeatures ?? new ChangeTrackingList<string>(),
                featuresRule,
                enableAsyncOperation,
                provisioningState,
                enableThirdPartyS2S,
                subscriptionLifecycleNotificationSpecifications,
                isPureProxy,
                identityManagement,
                checkNameAvailabilitySpecifications,
                disallowedActionVerbs ?? new ChangeTrackingList<string>(),
                serviceTreeInfos ?? new ChangeTrackingList<ServiceTreeInfo>(),
                requestHeaderOptions,
                subscriptionStateRules ?? new ChangeTrackingList<ProviderSubscriptionStateRule>(),
                templateDeploymentOptions,
                extendedLocations ?? new ChangeTrackingList<ProviderHubExtendedLocationOptions>(),
                resourceMovePolicy,
                resourceDeletionPolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceTypeRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceTypeRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        ResourceTypeRegistrationProperties IPersistableModel<ResourceTypeRegistrationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceTypeRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceTypeRegistrationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceTypeRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceTypeRegistrationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
