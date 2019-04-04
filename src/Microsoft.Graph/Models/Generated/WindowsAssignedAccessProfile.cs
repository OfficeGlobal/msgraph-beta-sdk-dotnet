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
    /// The type Windows Assigned Access Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsAssignedAccessProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets profile name.
        /// This is a friendly nameÂ used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileName", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets show task bar.
        /// This setting allows the admin to specify whether the Task Bar is shown or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showTaskBar", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowTaskBar { get; set; }
    
        /// <summary>
        /// Gets or sets app user model ids.
        /// These are the only Windows Store Apps that will be available to launch from the Start menu.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appUserModelIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AppUserModelIds { get; set; }
    
        /// <summary>
        /// Gets or sets desktop app paths.
        /// These are the paths of the Desktop Apps that will be available on the Start menu and the only apps the user will be able to launch.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "desktopAppPaths", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DesktopAppPaths { get; set; }
    
        /// <summary>
        /// Gets or sets user accounts.
        /// The user accounts that will be locked to this kiosk configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAccounts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UserAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets start menu layout xml.
        /// Allows admins to override the default Start layout and prevents the user from changing it.Â The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startMenuLayoutXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] StartMenuLayoutXml { get; set; }
    
    }
}

