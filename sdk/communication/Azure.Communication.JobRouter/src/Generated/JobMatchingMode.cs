// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// A matching mode of one of the following types:
    /// QueueAndMatchMode: Used when matching worker to a job is required to be done right after job is queued.
    /// ScheduleAndSuspendMode: Used for scheduling jobs to be queued at a future time. At specified time, matching of a worker to the job will not start automatically.
    /// SuspendMode: Used when matching workers to a job needs to be suspended.
    /// Please note <see cref="JobMatchingMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ScheduleAndSuspendMode"/>, <see cref="QueueAndMatchMode"/> and <see cref="SuspendMode"/>.
    /// </summary>
    public abstract partial class JobMatchingMode
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JobMatchingMode"/>. </summary>
        protected JobMatchingMode()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobMatchingMode"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of JobMatchingMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobMatchingMode(JobMatchingModeKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
