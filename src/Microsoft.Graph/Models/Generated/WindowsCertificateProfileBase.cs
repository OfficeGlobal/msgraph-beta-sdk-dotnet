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
    /// The type Windows Certificate Profile Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsCertificateProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal WindowsCertificateProfileBase constructor
		///</summary>
        protected internal WindowsCertificateProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets renewal threshold percentage.
        /// Certificate renewal threshold percentage. Valid values 1 to 99
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewalThresholdPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RenewalThresholdPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets key storage provider.
        /// Key Storage Provider (KSP)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyStorageProvider", Required = Newtonsoft.Json.Required.Default)]
        public KeyStorageProviderOption? KeyStorageProvider { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format.
        /// Certificate Subject Name Format
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormat", Required = Newtonsoft.Json.Required.Default)]
        public SubjectNameFormat? SubjectNameFormat { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name type.
        /// Certificate Subject Alternative Name Type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameType", Required = Newtonsoft.Json.Required.Default)]
        public SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// Value for the Certificate Validity Period
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// Scale for the Certificate Validity Period
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodScale", Required = Newtonsoft.Json.Required.Default)]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
    }
}

