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
    /// The type Impossible Travel Risk Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ImpossibleTravelRiskEvent : LocatedRiskEvent
    {
    
        /// <summary>
        /// Gets or sets user agent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAgent", Required = Newtonsoft.Json.Required.Default)]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Gets or sets device information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceInformation", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceInformation { get; set; }
    
        /// <summary>
        /// Gets or sets is atypical location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAtypicalLocation", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAtypicalLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous signin date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousSigninDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? PreviousSigninDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets previous location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousLocation", Required = Newtonsoft.Json.Required.Default)]
        public SignInLocation PreviousLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous ip address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousIpAddress", Required = Newtonsoft.Json.Required.Default)]
        public string PreviousIpAddress { get; set; }
    
    }
}

