// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type ParticipantConfigureMixerRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ParticipantConfigureMixerRequestBody
    {
    
        /// <summary>
        /// Gets or sets ParticipantMixerLevels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participantMixerLevels", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ParticipantMixerLevel> ParticipantMixerLevels { get; set; }
    
        /// <summary>
        /// Gets or sets ClientContext.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientContext", Required = Newtonsoft.Json.Required.Default)]
        public string ClientContext { get; set; }
    
    }
}
