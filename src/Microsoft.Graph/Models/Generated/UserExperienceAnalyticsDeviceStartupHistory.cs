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
    /// The type User Experience Analytics Device Startup History.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsDeviceStartupHistory : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsDeviceStartupHistory constructor
		///</summary>
        public UserExperienceAnalyticsDeviceStartupHistory()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsDeviceStartupHistory";
        }
	
        /// <summary>
        /// Gets or sets device id.
        /// The user experience analytics device id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets start time.
        /// The user experience analytics device boot start time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartTime { get; set; }
    
        /// <summary>
        /// Gets or sets core boot time in ms.
        /// The user experience analytics device core boot time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "coreBootTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CoreBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets group policy boot time in ms.
        /// The User experience analytics Device group policy boot time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyBootTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? GroupPolicyBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets feature update boot time in ms.
        /// The user experience analytics device feature update time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdateBootTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FeatureUpdateBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets total boot time in ms.
        /// The user experience analytics device total boot time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalBootTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets group policy login time in ms.
        /// The User experience analytics Device group policy login time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyLoginTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? GroupPolicyLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets core login time in ms.
        /// The user experience analytics device core login time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "coreLoginTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CoreLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets total login time in ms.
        /// The user experience analytics device total login time in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLoginTimeInMs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets is first login.
        /// The user experience analytics device first login.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFirstLogin", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFirstLogin { get; set; }
    
        /// <summary>
        /// Gets or sets is feature update.
        /// The user experience analytics device boot record is a feature update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFeatureUpdate", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFeatureUpdate { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// The user experience analytics device boot record's operating system version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystemVersion { get; set; }
    
    }
}

