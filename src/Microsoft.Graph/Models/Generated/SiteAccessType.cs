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
    /// The enum SiteAccessType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SiteAccessType
    {
    
        /// <summary>
        /// Block
        /// </summary>
        Block = 0,
	
        /// <summary>
        /// Full
        /// </summary>
        Full = 1,
	
        /// <summary>
        /// Limited
        /// </summary>
        Limited = 2,
	
    }
}