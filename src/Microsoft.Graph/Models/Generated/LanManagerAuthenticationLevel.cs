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
    /// The enum LanManagerAuthenticationLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LanManagerAuthenticationLevel
    {
    
        /// <summary>
        /// Lm And Nltm
        /// </summary>
        LmAndNltm = 0,
	
        /// <summary>
        /// Lm Ntlm And Ntlm V2
        /// </summary>
        LmNtlmAndNtlmV2 = 1,
	
        /// <summary>
        /// Lm And Ntlm Only
        /// </summary>
        LmAndNtlmOnly = 2,
	
        /// <summary>
        /// Lm And Ntlm V2
        /// </summary>
        LmAndNtlmV2 = 3,
	
        /// <summary>
        /// Lm Ntlm V2And Not Lm
        /// </summary>
        LmNtlmV2AndNotLm = 4,
	
        /// <summary>
        /// Lm Ntlm V2And Not Lm Or Ntm
        /// </summary>
        LmNtlmV2AndNotLmOrNtm = 5,
	
    }
}
