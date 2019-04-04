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
    /// The type Dep Onboarding Setting.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DepOnboardingSetting : Entity
    {
    
        /// <summary>
        /// Gets or sets apple identifier.
        /// The Apple ID used to obtain the current token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string AppleIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets token expiration date time.
        /// When the token will expire.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// When the service was onboarded.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last successful sync date time.
        /// When the service last syned with Intune
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSuccessfulSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync triggered date time.
        /// When Intune last requested a sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncTriggeredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncTriggeredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets share token with school data sync service.
        /// Whether or not the Dep token sharing is enabled with the School Data Sync service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shareTokenWithSchoolDataSyncService", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShareTokenWithSchoolDataSyncService { get; set; }
    
        /// <summary>
        /// Gets or sets last sync error code.
        /// Error code reported by Apple during last dep sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncErrorCode", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LastSyncErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets token type.
        /// Gets or sets the Dep Token Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenType", Required = Newtonsoft.Json.Required.Default)]
        public DepTokenType? TokenType { get; set; }
    
        /// <summary>
        /// Gets or sets token name.
        /// Friendly Name for Dep Token
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenName", Required = Newtonsoft.Json.Required.Default)]
        public string TokenName { get; set; }
    
        /// <summary>
        /// Gets or sets synced device count.
        /// Gets synced device count
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SyncedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets data sharing consent granted.
        /// Consent granted for data sharing with Apple Dep Service
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataSharingConsentGranted", Required = Newtonsoft.Json.Required.Default)]
        public bool? DataSharingConsentGranted { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets default ios enrollment profile.
        /// Default iOS Enrollment Profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultIosEnrollmentProfile", Required = Newtonsoft.Json.Required.Default)]
        public DepIOSEnrollmentProfile DefaultIosEnrollmentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets default mac os enrollment profile.
        /// Default MacOs Enrollment Profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultMacOsEnrollmentProfile", Required = Newtonsoft.Json.Required.Default)]
        public DepMacOSEnrollmentProfile DefaultMacOsEnrollmentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment profiles.
        /// The enrollment profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDepOnboardingSettingEnrollmentProfilesCollectionPage EnrollmentProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets imported apple device identities.
        /// The imported Apple device identities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedAppleDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionPage ImportedAppleDeviceIdentities { get; set; }
    
    }
}

