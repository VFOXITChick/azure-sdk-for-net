// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobState
    {
        /// <summary>
        /// The job is available to have tasks scheduled.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>
        /// A user has requested that the job be disabled, but the disable
        /// operation is still in progress (for example, waiting for tasks to
        /// terminate).
        /// </summary>
        [EnumMember(Value = "disabling")]
        Disabling,
        /// <summary>
        /// A user has disabled the job. No tasks are running, and no new tasks
        /// will be scheduled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// A user has requested that the job be enabled, but the enable
        /// operation is still in progress.
        /// </summary>
        [EnumMember(Value = "enabling")]
        Enabling,
        /// <summary>
        /// The job is about to complete, either because a Job Manager task has
        /// completed or because the user has terminated the job, but the
        /// terminate operation is still in progress (for example, because Job
        /// Release tasks are running).
        /// </summary>
        [EnumMember(Value = "terminating")]
        Terminating,
        /// <summary>
        /// All tasks have terminated, and the system will not accept any more
        /// tasks or any further changes to the job.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// A user has requested that the job be deleted, but the delete
        /// operation is still in progress (for example, because the system is
        /// still terminating running tasks).
        /// </summary>
        [EnumMember(Value = "deleting")]
        Deleting
    }
    internal static class JobStateEnumExtension
    {
        internal static string ToSerializedValue(this JobState? value)
        {
            return value == null ? null : ((JobState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobState value)
        {
            switch( value )
            {
                case JobState.Active:
                    return "active";
                case JobState.Disabling:
                    return "disabling";
                case JobState.Disabled:
                    return "disabled";
                case JobState.Enabling:
                    return "enabling";
                case JobState.Terminating:
                    return "terminating";
                case JobState.Completed:
                    return "completed";
                case JobState.Deleting:
                    return "deleting";
            }
            return null;
        }

        internal static JobState? ParseJobState(this string value)
        {
            switch( value )
            {
                case "active":
                    return JobState.Active;
                case "disabling":
                    return JobState.Disabling;
                case "disabled":
                    return JobState.Disabled;
                case "enabling":
                    return JobState.Enabling;
                case "terminating":
                    return JobState.Terminating;
                case "completed":
                    return JobState.Completed;
                case "deleting":
                    return JobState.Deleting;
            }
            return null;
        }
    }
}
