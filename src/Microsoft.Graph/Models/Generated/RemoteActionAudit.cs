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
    /// The type Remote Action Audit.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RemoteActionAudit : Entity
    {
    
        /// <summary>
        /// Gets or sets device display name.
        /// Intune device name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// [deprecated] Please use InitiatedByUserPrincipalName instead.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by user principal name.
        /// User who initiated the device action, format is UPN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiatedByUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string InitiatedByUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets action.
        /// The action name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public RemoteAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets request date time.
        /// Time when the action was issued, given in UTC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RequestDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device owner user principal name.
        /// Upn of the device owner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOwnerUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceOwnerUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets device imei.
        /// IMEI of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceIMEI", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceIMEI { get; set; }
    
        /// <summary>
        /// Gets or sets action state.
        /// Action state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionState", Required = Newtonsoft.Json.Required.Default)]
        public ActionState? ActionState { get; set; }
    
    }
}

