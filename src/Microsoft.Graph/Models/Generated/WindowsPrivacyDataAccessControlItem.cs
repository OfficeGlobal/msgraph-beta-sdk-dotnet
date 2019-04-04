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
    /// The type Windows Privacy Data Access Control Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsPrivacyDataAccessControlItem : Entity
    {
    
        /// <summary>
        /// Gets or sets access level.
        /// This indicates an access level for the privacy data category to which the specified application will be given to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessLevel", Required = Newtonsoft.Json.Required.Default)]
        public WindowsPrivacyDataAccessLevel? AccessLevel { get; set; }
    
        /// <summary>
        /// Gets or sets data category.
        /// This indicates a privacy data category to which the specific access control will apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataCategory", Required = Newtonsoft.Json.Required.Default)]
        public WindowsPrivacyDataCategory? DataCategory { get; set; }
    
        /// <summary>
        /// Gets or sets app package family name.
        /// The Package Family Name of a Windows app. When set, the access level applies to the specified application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appPackageFamilyName", Required = Newtonsoft.Json.Required.Default)]
        public string AppPackageFamilyName { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The Package Family Name of a Windows app. When set, the access level applies to the specified application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
    }
}

