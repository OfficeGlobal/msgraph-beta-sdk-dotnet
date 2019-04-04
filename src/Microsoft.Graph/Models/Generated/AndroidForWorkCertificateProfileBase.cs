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
    /// The type Android For Work Certificate Profile Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkCertificateProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AndroidForWorkCertificateProfileBase constructor
		///</summary>
        protected internal AndroidForWorkCertificateProfileBase()
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
        /// Gets or sets subject name format.
        /// Certificate Subject Name Format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormat", Required = Newtonsoft.Json.Required.Default)]
        public SubjectNameFormat? SubjectNameFormat { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// Value for the Certificate Validity Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// Scale for the Certificate Validity Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodScale", Required = Newtonsoft.Json.Required.Default)]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extendedKeyUsages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate.
        /// Trusted Root Certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkTrustedRootCertificate RootCertificate { get; set; }
    
    }
}

