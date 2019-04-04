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
    /// The type Office Suite App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OfficeSuiteApp : MobileApp
    {
    
        /// <summary>
        /// Gets or sets auto accept eula.
        /// The value to accept the EULA automatically on the enduser's device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autoAcceptEula", Required = Newtonsoft.Json.Required.Default)]
        public bool? AutoAcceptEula { get; set; }
    
        /// <summary>
        /// Gets or sets product ids.
        /// The Product Ids that represent the Office365 Suite SKU.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OfficeProductId> ProductIds { get; set; }
    
        /// <summary>
        /// Gets or sets excluded apps.
        /// The property to represent the apps which are excluded from the selected Office365 Product Id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "excludedApps", Required = Newtonsoft.Json.Required.Default)]
        public ExcludedApps ExcludedApps { get; set; }
    
        /// <summary>
        /// Gets or sets use shared computer activation.
        /// The property to represent that whether the shared computer activation is used not for Office365 app suite.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useSharedComputerActivation", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseSharedComputerActivation { get; set; }
    
        /// <summary>
        /// Gets or sets update channel.
        /// The property to represent the Office365 Update Channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateChannel", Required = Newtonsoft.Json.Required.Default)]
        public OfficeUpdateChannel? UpdateChannel { get; set; }
    
        /// <summary>
        /// Gets or sets office platform architecture.
        /// The property to represent the Office365 app suite version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officePlatformArchitecture", Required = Newtonsoft.Json.Required.Default)]
        public WindowsArchitecture? OfficePlatformArchitecture { get; set; }
    
        /// <summary>
        /// Gets or sets locales to install.
        /// The property to represent the locales which are installed when the apps from Office365 is installed. It uses standard RFC 6033. Ref: https://technet.microsoft.com/en-us/library/cc179219(v=office.16).aspx
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localesToInstall", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> LocalesToInstall { get; set; }
    
        /// <summary>
        /// Gets or sets install progress display level.
        /// To specify the level of display for the Installation Progress Setup UI on the Device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installProgressDisplayLevel", Required = Newtonsoft.Json.Required.Default)]
        public OfficeSuiteInstallProgressDisplayLevel? InstallProgressDisplayLevel { get; set; }
    
        /// <summary>
        /// Gets or sets should uninstall older versions of office.
        /// The property to determine whether to uninstall existing Office MSI if an Office365 app suite is deployed to the device or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shouldUninstallOlderVersionsOfOffice", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShouldUninstallOlderVersionsOfOffice { get; set; }
    
        /// <summary>
        /// Gets or sets target version.
        /// The property to represent the specific target version for the Office365 app suite that should be remained deployed on the devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetVersion", Required = Newtonsoft.Json.Required.Default)]
        public string TargetVersion { get; set; }
    
        /// <summary>
        /// Gets or sets update version.
        /// The property to represent the update version in which the specific target version is available for the Office365 app suite.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateVersion", Required = Newtonsoft.Json.Required.Default)]
        public string UpdateVersion { get; set; }
    
        /// <summary>
        /// Gets or sets office configuration xml.
        /// The property to represent the XML configuration file that can be specified for Office ProPlus Apps. Takes precedence over all other properties. When present, the XML configuration file will be used to create the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeConfigurationXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] OfficeConfigurationXml { get; set; }
    
    }
}

