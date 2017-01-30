// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for ComputeNodeState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComputeNodeState
    {
        [System.Runtime.Serialization.EnumMember(Value = "idle")]
        Idle,
        [System.Runtime.Serialization.EnumMember(Value = "rebooting")]
        Rebooting,
        [System.Runtime.Serialization.EnumMember(Value = "reimaging")]
        Reimaging,
        [System.Runtime.Serialization.EnumMember(Value = "running")]
        Running,
        [System.Runtime.Serialization.EnumMember(Value = "unusable")]
        Unusable,
        [System.Runtime.Serialization.EnumMember(Value = "creating")]
        Creating,
        [System.Runtime.Serialization.EnumMember(Value = "starting")]
        Starting,
        [System.Runtime.Serialization.EnumMember(Value = "waitingforstarttask")]
        Waitingforstarttask,
        [System.Runtime.Serialization.EnumMember(Value = "starttaskfailed")]
        Starttaskfailed,
        [System.Runtime.Serialization.EnumMember(Value = "unknown")]
        Unknown,
        [System.Runtime.Serialization.EnumMember(Value = "leavingpool")]
        Leavingpool,
        [System.Runtime.Serialization.EnumMember(Value = "offline")]
        Offline
    }
    internal static class ComputeNodeStateEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeState? value )  =>
            value == null ? null : (( ComputeNodeState )value).ToSerializedValue();

        internal static string ToSerializedValue(this ComputeNodeState value )
        {
            switch( value )
            {
                case ComputeNodeState.Idle:
                    return "idle";
                case ComputeNodeState.Rebooting:
                    return "rebooting";
                case ComputeNodeState.Reimaging:
                    return "reimaging";
                case ComputeNodeState.Running:
                    return "running";
                case ComputeNodeState.Unusable:
                    return "unusable";
                case ComputeNodeState.Creating:
                    return "creating";
                case ComputeNodeState.Starting:
                    return "starting";
                case ComputeNodeState.Waitingforstarttask:
                    return "waitingforstarttask";
                case ComputeNodeState.Starttaskfailed:
                    return "starttaskfailed";
                case ComputeNodeState.Unknown:
                    return "unknown";
                case ComputeNodeState.Leavingpool:
                    return "leavingpool";
                case ComputeNodeState.Offline:
                    return "offline";
            }
            return null;
        }

        internal static ComputeNodeState? ParseComputeNodeState( this string value )
        {
            switch( value )
            {
                case "idle":
                    return ComputeNodeState.Idle;
                case "rebooting":
                    return ComputeNodeState.Rebooting;
                case "reimaging":
                    return ComputeNodeState.Reimaging;
                case "running":
                    return ComputeNodeState.Running;
                case "unusable":
                    return ComputeNodeState.Unusable;
                case "creating":
                    return ComputeNodeState.Creating;
                case "starting":
                    return ComputeNodeState.Starting;
                case "waitingforstarttask":
                    return ComputeNodeState.Waitingforstarttask;
                case "starttaskfailed":
                    return ComputeNodeState.Starttaskfailed;
                case "unknown":
                    return ComputeNodeState.Unknown;
                case "leavingpool":
                    return ComputeNodeState.Leavingpool;
                case "offline":
                    return ComputeNodeState.Offline;
            }
            return null;
        }
    }
}
