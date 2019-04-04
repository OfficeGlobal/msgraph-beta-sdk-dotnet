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
    /// The type Android Work Profile Enterprise Wi Fi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileEnterpriseWiFiConfiguration : AndroidWorkProfileWiFiConfiguration
    {
    
        /// <summary>
        /// Gets or sets eap type.
        /// Indicates the type of EAP protocol set on the the Wi-Fi endpoint (router).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eapType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidEapType? EapType { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Indicates the Authentication Method the client (device) needs to use when the EAP Type is configured to PEAP or EAP-TTLS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public WiFiAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets inner authentication protocol for eap ttls.
        /// Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "innerAuthenticationProtocolForEapTtls", Required = Newtonsoft.Json.Required.Default)]
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls { get; set; }
    
        /// <summary>
        /// Gets or sets inner authentication protocol for peap.
        /// Non-EAP Method for Authentication (Inner Identity) when EAP Type is PEAP and Authenticationmethod is Username and Password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "innerAuthenticationProtocolForPeap", Required = Newtonsoft.Json.Required.Default)]
        public NonEapAuthenticationMethodForPeap? InnerAuthenticationProtocolForPeap { get; set; }
    
        /// <summary>
        /// Gets or sets outer identity privacy temporary value.
        /// Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS or PEAP. The String provided here is used to mask the username of individual users when they attempt to connect to Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outerIdentityPrivacyTemporaryValue", Required = Newtonsoft.Json.Required.Default)]
        public string OuterIdentityPrivacyTemporaryValue { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate for server validation.
        /// Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS, EAP-TTLS or PEAP. This is the certificate presented by the Wi-Fi endpoint when the device attempts to connect to Wi-Fi endpoint. The device (or user) must accept this certificate to continue the connection attempt.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificateForServerValidation", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWorkProfileTrustedRootCertificate RootCertificateForServerValidation { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate for client authentication.
        /// Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication). This is the certificate presented by client to the Wi-Fi endpoint. The authentication server sitting behind the Wi-Fi endpoint must accept this certificate to successfully establish a Wi-Fi connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificateForClientAuthentication", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWorkProfileCertificateProfileBase IdentityCertificateForClientAuthentication { get; set; }
    
    }
}

