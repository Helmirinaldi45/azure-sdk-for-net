// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Base class for all execution activities.
    /// Please note <see cref="ExecutionActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="LookupActivity"/>, <see cref="DataFactoryScriptActivity"/>, <see cref="SynapseSparkJobDefinitionActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SynapseNotebookActivity"/> and <see cref="WebActivity"/>.
    /// </summary>
    public partial class ExecutionActivity : PipelineActivity
    {
        /// <summary> Initializes a new instance of <see cref="ExecutionActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ExecutionActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ActivityType = "Execution";
        }

        /// <summary> Initializes a new instance of <see cref="ExecutionActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        internal ExecutionActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Policy = policy;
            ActivityType = activityType ?? "Execution";
        }

        /// <summary> Initializes a new instance of <see cref="ExecutionActivity"/> for deserialization. </summary>
        internal ExecutionActivity()
        {
        }

        /// <summary> Linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> Activity policy. </summary>
        public PipelineActivityPolicy Policy { get; set; }
    }
}
