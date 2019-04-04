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
    /// The type Journal.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Journal : Entity
    {
    
        /// <summary>
        /// Gets or sets code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "code", Required = Newtonsoft.Json.Required.Default)]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets balancing account id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balancingAccountId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? BalancingAccountId { get; set; }
    
        /// <summary>
        /// Gets or sets balancing account number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balancingAccountNumber", Required = Newtonsoft.Json.Required.Default)]
        public string BalancingAccountNumber { get; set; }
    
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account", Required = Newtonsoft.Json.Required.Default)]
        public Account Account { get; set; }
    
        /// <summary>
        /// Gets or sets journal lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "journalLines", Required = Newtonsoft.Json.Required.Default)]
        public IJournalJournalLinesCollectionPage JournalLines { get; set; }
    
    }
}

