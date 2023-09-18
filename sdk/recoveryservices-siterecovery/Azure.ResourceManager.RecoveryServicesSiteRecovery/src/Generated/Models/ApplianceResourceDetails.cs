// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Details of the appliance resource. </summary>
    public partial class ApplianceResourceDetails
    {
        /// <summary> Initializes a new instance of ApplianceResourceDetails. </summary>
        internal ApplianceResourceDetails()
        {
        }

        /// <summary> Initializes a new instance of ApplianceResourceDetails. </summary>
        /// <param name="capacity"> A value indicating the total capacity of appliance resource. </param>
        /// <param name="processUtilization"> A value indicating the utilization percentage by gateway agent on appliance. </param>
        /// <param name="totalUtilization"> A value indicating the total utilization percentage for all processes on the appliance. </param>
        /// <param name="status"> A value indicating the status of appliance resource. </param>
        internal ApplianceResourceDetails(long? capacity, double? processUtilization, double? totalUtilization, string status)
        {
            Capacity = capacity;
            ProcessUtilization = processUtilization;
            TotalUtilization = totalUtilization;
            Status = status;
        }

        /// <summary> A value indicating the total capacity of appliance resource. </summary>
        public long? Capacity { get; }
        /// <summary> A value indicating the utilization percentage by gateway agent on appliance. </summary>
        public double? ProcessUtilization { get; }
        /// <summary> A value indicating the total utilization percentage for all processes on the appliance. </summary>
        public double? TotalUtilization { get; }
        /// <summary> A value indicating the status of appliance resource. </summary>
        public string Status { get; }
    }
}
