// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the monitoring policies for the cluster upgrade. </summary>
    public partial class ManagedClusterMonitoringPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitoringPolicy"/>. </summary>
        /// <param name="healthCheckWaitDuration"> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="healthCheckRetryTimeout"/>, <paramref name="upgradeTimeout"/> or <paramref name="upgradeDomainTimeout"/> is null. </exception>
        public ManagedClusterMonitoringPolicy(TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, string healthCheckRetryTimeout, string upgradeTimeout, string upgradeDomainTimeout)
        {
            Argument.AssertNotNull(healthCheckRetryTimeout, nameof(healthCheckRetryTimeout));
            Argument.AssertNotNull(upgradeTimeout, nameof(upgradeTimeout));
            Argument.AssertNotNull(upgradeDomainTimeout, nameof(upgradeDomainTimeout));

            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitoringPolicy"/>. </summary>
        /// <param name="healthCheckWaitDuration"> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterMonitoringPolicy(TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, string healthCheckRetryTimeout, string upgradeTimeout, string upgradeDomainTimeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterMonitoringPolicy"/> for deserialization. </summary>
        internal ManagedClusterMonitoringPolicy()
        {
        }

        /// <summary> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan HealthCheckWaitDuration { get; set; }
        /// <summary> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan HealthCheckStableDuration { get; set; }
        /// <summary> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public string HealthCheckRetryTimeout { get; set; }
        /// <summary> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public string UpgradeTimeout { get; set; }
        /// <summary> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public string UpgradeDomainTimeout { get; set; }
    }
}
