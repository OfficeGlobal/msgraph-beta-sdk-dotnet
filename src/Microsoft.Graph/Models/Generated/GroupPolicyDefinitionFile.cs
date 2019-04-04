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
    /// The type Group Policy Definition File.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyDefinitionFile : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The localized friendly name of the ADMX file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The localized description of the policy settings in the ADMX file. The default value is empty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets language codes.
        /// The supported language codes for the ADMX file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "languageCodes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> LanguageCodes { get; set; }
    
        /// <summary>
        /// Gets or sets target prefix.
        /// Specifies the logical name that refers to the namespace within the ADMX file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetPrefix", Required = Newtonsoft.Json.Required.Default)]
        public string TargetPrefix { get; set; }
    
        /// <summary>
        /// Gets or sets target namespace.
        /// Specifies the URI used to identify the namespace within the ADMX file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetNamespace", Required = Newtonsoft.Json.Required.Default)]
        public string TargetNamespace { get; set; }
    
        /// <summary>
        /// Gets or sets policy type.
        /// Specifies the type of group policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyType", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicyType? PolicyType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets definitions.
        /// The group policy definitions associated with the file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definitions", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesPage Definitions { get; set; }
    
    }
}

