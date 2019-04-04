// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum SecureAssessmentAccountType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SecureAssessmentAccountType
    {
    
        /// <summary>
        /// Azure ADAccount
        /// </summary>
        AzureADAccount = 0,
	
        /// <summary>
        /// Domain Account
        /// </summary>
        DomainAccount = 1,
	
        /// <summary>
        /// Local Account
        /// </summary>
        LocalAccount = 2,
	
    }
}
