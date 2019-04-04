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
    /// The type Mac OSGeneral Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppsList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// List that is in the CompliantAppsList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppListType", Required = Newtonsoft.Json.Required.Default)]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets email in domain suffixes.
        /// An email address lacking a suffix that matches any of these strings will be considered out-of-domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailInDomainSuffixes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EmailInDomainSuffixes { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Block simple passwords.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// Number of character sets a password must contain. Valid values 0 to 4
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity required before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity required before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of password that is required. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Whether or not to require a password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets keychain block cloud sync.
        /// Indicates whether or not iCloud keychain synchronization is blocked (macOS 10.12 and later).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keychainBlockCloudSync", Required = Newtonsoft.Json.Required.Default)]
        public bool? KeychainBlockCloudSync { get; set; }
    
        /// <summary>
        /// Gets or sets air print blocked.
        /// Indicates whether or not AirPrint is blocked (macOS 10.12 and later).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "airPrintBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? AirPrintBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets air print force trusted tls.
        /// Indicates if trusted certificates are required for TLS printing communication (macOS 10.13 and later).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "airPrintForceTrustedTLS", Required = Newtonsoft.Json.Required.Default)]
        public bool? AirPrintForceTrustedTLS { get; set; }
    
        /// <summary>
        /// Gets or sets air print blocki beacon discovery.
        /// Indicates whether or not iBeacon discovery of AirPrint printers is blocked. This prevents spurious AirPrint Bluetooth beacons from phishing for network traffic (macOS 10.3 and later).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "airPrintBlockiBeaconDiscovery", Required = Newtonsoft.Json.Required.Default)]
        public bool? AirPrintBlockiBeaconDiscovery { get; set; }
    
        /// <summary>
        /// Gets or sets safari block autofill.
        /// Indicates whether or not to block the user from using Auto fill in Safari.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "safariBlockAutofill", Required = Newtonsoft.Json.Required.Default)]
        public bool? SafariBlockAutofill { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// Indicates whether or not to block the user from accessing the camera of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets i tunes block music service.
        /// Indicates whether or not to block Music service and revert Music app to classic mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iTunesBlockMusicService", Required = Newtonsoft.Json.Required.Default)]
        public bool? ITunesBlockMusicService { get; set; }
    
        /// <summary>
        /// Gets or sets spotlight block internet results.
        /// Indicates whether or not to block Spotlight from returning any results from an Internet search.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spotlightBlockInternetResults", Required = Newtonsoft.Json.Required.Default)]
        public bool? SpotlightBlockInternetResults { get; set; }
    
        /// <summary>
        /// Gets or sets keyboard block dictation.
        /// Indicates whether or not to block the user from using dictation input.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyboardBlockDictation", Required = Newtonsoft.Json.Required.Default)]
        public bool? KeyboardBlockDictation { get; set; }
    
        /// <summary>
        /// Gets or sets definition lookup blocked.
        /// Indicates whether or not to block definition lookup.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definitionLookupBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? DefinitionLookupBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apple watch block auto unlock.
        /// Indicates whether or to block users from unlocking their Mac with Apple Watch.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleWatchBlockAutoUnlock", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppleWatchBlockAutoUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets i tunes block file sharing.
        /// Indicates whether or not to block files from being transferred using iTunes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iTunesBlockFileSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? ITunesBlockFileSharing { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block document sync.
        /// Indicates whether or not to block iCloud document sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockDocumentSync", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockDocumentSync { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block mail.
        /// Indicates whether or not to block iCloud from syncing mail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockMail", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockMail { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block address book.
        /// Indicates whether or not to block iCloud from syncing contacts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockAddressBook", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockAddressBook { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block calendar.
        /// Indicates whether or not to block iCloud from syncing calendars.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockCalendar", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block reminders.
        /// Indicates whether or not to block iCloud from syncing reminders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockReminders", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockReminders { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block bookmarks.
        /// Indicates whether or not to block iCloud from syncing bookmarks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockBookmarks", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockBookmarks { get; set; }
    
        /// <summary>
        /// Gets or sets i cloud block notes.
        /// Indicates whether or not to block iCloud from syncing notes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCloudBlockNotes", Required = Newtonsoft.Json.Required.Default)]
        public bool? ICloudBlockNotes { get; set; }
    
        /// <summary>
        /// Gets or sets air drop blocked.
        /// Indicates whether or not to allow AirDrop.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "airDropBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? AirDropBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets password block modification.
        /// Indicates whether or not to allow passcode modification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockModification", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockModification { get; set; }
    
        /// <summary>
        /// Gets or sets password block fingerprint unlock.
        /// Indicates whether or not to block fingerprint unlock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockFingerprintUnlock", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockFingerprintUnlock { get; set; }
    
        /// <summary>
        /// Gets or sets password block auto fill.
        /// Indicates whether or not to block the AutoFill Passwords feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockAutoFill", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockAutoFill { get; set; }
    
        /// <summary>
        /// Gets or sets password block proximity requests.
        /// Indicates whether or not to block requesting passwords from nearby devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockProximityRequests", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockProximityRequests { get; set; }
    
        /// <summary>
        /// Gets or sets password block air drop sharing.
        /// Indicates whether or not to block sharing passwords with the AirDrop passwords feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockAirDropSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockAirDropSharing { get; set; }
    
        /// <summary>
        /// Gets or sets software updates enforced delay in days.
        /// Sets how many days a software update will be delyed for a supervised device. Valid values 0 to 90
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdatesEnforcedDelayInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SoftwareUpdatesEnforcedDelayInDays { get; set; }
    
        /// <summary>
        /// Gets or sets software updates force delayed.
        /// Indicates whether or not to delay user visibility of software updates when the device is in supervised mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdatesForceDelayed", Required = Newtonsoft.Json.Required.Default)]
        public bool? SoftwareUpdatesForceDelayed { get; set; }
    
        /// <summary>
        /// Gets or sets content caching blocked.
        /// Indicates whether or not to allow content caching.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingBlocked { get; set; }
    
    }
}

