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
    /// The enum AccessLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AccessLevel
    {
    
        /// <summary>
        /// Everyone
        /// </summary>
        Everyone = 0,
	
        /// <summary>
        /// Invited
        /// </summary>
        Invited = 1,
	
        /// <summary>
        /// Locked
        /// </summary>
        Locked = 2,
	
        /// <summary>
        /// Same Enterprise
        /// </summary>
        SameEnterprise = 3,
	
    }
}
