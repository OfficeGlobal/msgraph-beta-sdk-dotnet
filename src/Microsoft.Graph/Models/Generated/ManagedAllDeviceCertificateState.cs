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
    /// The type Managed All Device Certificate State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAllDeviceCertificateState : Entity
    {
    
        /// <summary>
        /// Gets or sets certificate revoke status.
        /// Revoke status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateRevokeStatus", Required = Newtonsoft.Json.Required.Default)]
        public CertificateRevocationStatus? CertificateRevokeStatus { get; set; }
    
        /// <summary>
        /// Gets or sets managed device display name.
        /// Device display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate expiration date time.
        /// Certificate expiry date
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CertificateExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets certificate issuer name.
        /// Issuer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateIssuerName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate thumbprint.
        /// Thumbprint
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateThumbprint", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets certificate serial number.
        /// Serial number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateSerialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateSerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets certificate subject name.
        /// Certificate subject name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateSubjectName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateSubjectName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate key usages.
        /// Key Usage
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateKeyUsages", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets certificate extended key usages.
        /// Enhanced Key Usage
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateExtendedKeyUsages", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets certificate issuance date time.
        /// Issuance date
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateIssuanceDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CertificateIssuanceDateTime { get; set; }
    
    }
}
