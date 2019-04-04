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
    /// The type OAuth2Permission Grant.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OAuth2PermissionGrant : Entity
    {
    
        /// <summary>
        /// Gets or sets client id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientId", Required = Newtonsoft.Json.Required.Default)]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets consent type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consentType", Required = Newtonsoft.Json.Required.Default)]
        public string ConsentType { get; set; }
    
        /// <summary>
        /// Gets or sets expiry time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiryTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpiryTime { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalId", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scope", Required = Newtonsoft.Json.Required.Default)]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartTime { get; set; }
    
    }
}

