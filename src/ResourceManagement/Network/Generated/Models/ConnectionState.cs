// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ConnectionState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ConnectionState>))]
    public class ConnectionState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ConnectionState>
    {
        public static readonly ConnectionState Reachable = Parse("Reachable");
        public static readonly ConnectionState Unreachable = Parse("Unreachable");
        public static readonly ConnectionState Unknown = Parse("Unknown");
    }
}
