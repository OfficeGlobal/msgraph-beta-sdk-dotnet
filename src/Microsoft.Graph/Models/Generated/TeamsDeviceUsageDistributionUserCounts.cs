// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Teams Device Usage Distribution User Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsDeviceUsageDistributionUserCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets web.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "web", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Web { get; set; }
    
        /// <summary>
        /// Gets or sets windows phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsPhone", Required = Newtonsoft.Json.Required.Default)]
        public Int64? WindowsPhone { get; set; }
    
        /// <summary>
        /// Gets or sets android phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidPhone", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AndroidPhone { get; set; }
    
        /// <summary>
        /// Gets or sets ios.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ios", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Ios { get; set; }
    
        /// <summary>
        /// Gets or sets mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Mac { get; set; }
    
        /// <summary>
        /// Gets or sets windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windows", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Windows { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

