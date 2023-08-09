// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudAgentPool data model.
    /// AgentPool represents the agent pool of Kubernetes cluster.
    /// </summary>
    public partial class NetworkCloudAgentPoolData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkCloudAgentPoolData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="mode"> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </param>
        /// <param name="vmSkuName"> The name of the VM SKU that determines the size of resources allocated for node VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSkuName"/> is null. </exception>
        public NetworkCloudAgentPoolData(AzureLocation location, long count, NetworkCloudAgentPoolMode mode, string vmSkuName) : base(location)
        {
            Argument.AssertNotNull(vmSkuName, nameof(vmSkuName));

            AvailabilityZones = new ChangeTrackingList<string>();
            Count = count;
            Labels = new ChangeTrackingList<KubernetesLabel>();
            Mode = mode;
            Taints = new ChangeTrackingList<KubernetesLabel>();
            VmSkuName = vmSkuName;
        }

        /// <summary> Initializes a new instance of NetworkCloudAgentPoolData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="administratorConfiguration"> The administrator credentials to be used for the nodes in this agent pool. </param>
        /// <param name="agentOptions"> The configurations that will be applied to each agent in this agent pool. </param>
        /// <param name="attachedNetworkConfiguration"> The configuration of networks being attached to the agent pool for use by the workloads that run on this Kubernetes cluster. </param>
        /// <param name="availabilityZones"> The list of availability zones of the Network Cloud cluster used for the provisioning of nodes in this agent pool. If not specified, all availability zones will be used. </param>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="detailedStatus"> The current status of the agent pool. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="kubernetesVersion"> The Kubernetes version running in this agent pool. </param>
        /// <param name="labels"> The labels applied to the nodes in this agent pool. </param>
        /// <param name="mode"> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </param>
        /// <param name="provisioningState"> The provisioning state of the agent pool. </param>
        /// <param name="taints"> The taints applied to the nodes in this agent pool. </param>
        /// <param name="upgradeSettings"> The configuration of the agent pool. </param>
        /// <param name="vmSkuName"> The name of the VM SKU that determines the size of resources allocated for node VMs. </param>
        internal NetworkCloudAgentPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, AdministratorConfiguration administratorConfiguration, NetworkCloudAgentConfiguration agentOptions, AttachedNetworkConfiguration attachedNetworkConfiguration, IList<string> availabilityZones, long count, AgentPoolDetailedStatus? detailedStatus, string detailedStatusMessage, string kubernetesVersion, IList<KubernetesLabel> labels, NetworkCloudAgentPoolMode mode, AgentPoolProvisioningState? provisioningState, IList<KubernetesLabel> taints, AgentPoolUpgradeSettings upgradeSettings, string vmSkuName) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AdministratorConfiguration = administratorConfiguration;
            AgentOptions = agentOptions;
            AttachedNetworkConfiguration = attachedNetworkConfiguration;
            AvailabilityZones = availabilityZones;
            Count = count;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            KubernetesVersion = kubernetesVersion;
            Labels = labels;
            Mode = mode;
            ProvisioningState = provisioningState;
            Taints = taints;
            UpgradeSettings = upgradeSettings;
            VmSkuName = vmSkuName;
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The administrator credentials to be used for the nodes in this agent pool. </summary>
        public AdministratorConfiguration AdministratorConfiguration { get; set; }
        /// <summary> The configurations that will be applied to each agent in this agent pool. </summary>
        public NetworkCloudAgentConfiguration AgentOptions { get; set; }
        /// <summary> The configuration of networks being attached to the agent pool for use by the workloads that run on this Kubernetes cluster. </summary>
        public AttachedNetworkConfiguration AttachedNetworkConfiguration { get; set; }
        /// <summary> The list of availability zones of the Network Cloud cluster used for the provisioning of nodes in this agent pool. If not specified, all availability zones will be used. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long Count { get; set; }
        /// <summary> The current status of the agent pool. </summary>
        public AgentPoolDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The Kubernetes version running in this agent pool. </summary>
        public string KubernetesVersion { get; }
        /// <summary> The labels applied to the nodes in this agent pool. </summary>
        public IList<KubernetesLabel> Labels { get; }
        /// <summary> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </summary>
        public NetworkCloudAgentPoolMode Mode { get; set; }
        /// <summary> The provisioning state of the agent pool. </summary>
        public AgentPoolProvisioningState? ProvisioningState { get; }
        /// <summary> The taints applied to the nodes in this agent pool. </summary>
        public IList<KubernetesLabel> Taints { get; }
        /// <summary> The configuration of the agent pool. </summary>
        internal AgentPoolUpgradeSettings UpgradeSettings { get; set; }
        /// <summary> The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1. </summary>
        public string UpgradeMaxSurge
        {
            get => UpgradeSettings is null ? default : UpgradeSettings.MaxSurge;
            set
            {
                if (UpgradeSettings is null)
                    UpgradeSettings = new AgentPoolUpgradeSettings();
                UpgradeSettings.MaxSurge = value;
            }
        }

        /// <summary> The name of the VM SKU that determines the size of resources allocated for node VMs. </summary>
        public string VmSkuName { get; set; }
    }
}
