// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume Backup Properties. </summary>
    public partial class NetAppVolumeBackupConfiguration
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

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupConfiguration"/>. </summary>
        /// <param name="backupPolicyId"> Backup Policy Resource ID. </param>
        /// <param name="isPolicyEnforced"> Policy Enforced. </param>
        /// <param name="isBackupEnabled"> Backup Enabled. </param>
        /// <param name="backupVaultId"> Backup Vault Resource ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupConfiguration(ResourceIdentifier backupPolicyId, bool? isPolicyEnforced, bool? isBackupEnabled, ResourceIdentifier backupVaultId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupPolicyId = backupPolicyId;
            IsPolicyEnforced = isPolicyEnforced;
            IsBackupEnabled = isBackupEnabled;
            BackupVaultId = backupVaultId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Policy Enforced. </summary>
        public bool? IsPolicyEnforced { get; set; }
        /// <summary> Backup Enabled. </summary>
        public bool? IsBackupEnabled { get; set; }
        /// <summary> Backup Vault Resource ID. </summary>
        public ResourceIdentifier BackupVaultId { get; set; }
    }
}
