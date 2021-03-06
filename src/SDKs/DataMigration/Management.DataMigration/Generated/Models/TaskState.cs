// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskState
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "FailedInputValidation")]
        FailedInputValidation,
        [EnumMember(Value = "Faulted")]
        Faulted
    }
    internal static class TaskStateEnumExtension
    {
        internal static string ToSerializedValue(this TaskState? value)
        {
            return value == null ? null : ((TaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskState value)
        {
            switch( value )
            {
                case TaskState.Unknown:
                    return "Unknown";
                case TaskState.Queued:
                    return "Queued";
                case TaskState.Running:
                    return "Running";
                case TaskState.Canceled:
                    return "Canceled";
                case TaskState.Succeeded:
                    return "Succeeded";
                case TaskState.Failed:
                    return "Failed";
                case TaskState.FailedInputValidation:
                    return "FailedInputValidation";
                case TaskState.Faulted:
                    return "Faulted";
            }
            return null;
        }

        internal static TaskState? ParseTaskState(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return TaskState.Unknown;
                case "Queued":
                    return TaskState.Queued;
                case "Running":
                    return TaskState.Running;
                case "Canceled":
                    return TaskState.Canceled;
                case "Succeeded":
                    return TaskState.Succeeded;
                case "Failed":
                    return TaskState.Failed;
                case "FailedInputValidation":
                    return TaskState.FailedInputValidation;
                case "Faulted":
                    return TaskState.Faulted;
            }
            return null;
        }
    }
}
