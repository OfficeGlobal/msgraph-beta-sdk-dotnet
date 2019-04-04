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
    /// The type Domain Security Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DomainSecurityProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets activity group names.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityGroupNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ActivityGroupNames { get; set; }
    
        /// <summary>
        /// Gets or sets azure subscription id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureSubscriptionId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets count hits.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countHits", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CountHits { get; set; }
    
        /// <summary>
        /// Gets or sets count in org.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countInOrg", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CountInOrg { get; set; }
    
        /// <summary>
        /// Gets or sets domain categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainCategories", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ReputationCategory> DomainCategories { get; set; }
    
        /// <summary>
        /// Gets or sets domain registered date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainRegisteredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets first seen date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstSeenDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FirstSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last seen date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSeenDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets registrant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registrant", Required = Newtonsoft.Json.Required.Default)]
        public DomainRegistrant Registrant { get; set; }
    
        /// <summary>
        /// Gets or sets risk score.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskScore", Required = Newtonsoft.Json.Required.Default)]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

