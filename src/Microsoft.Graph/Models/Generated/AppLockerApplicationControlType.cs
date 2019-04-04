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
    /// The enum AppLockerApplicationControlType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AppLockerApplicationControlType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Enforce Components And Store Apps
        /// </summary>
        EnforceComponentsAndStoreApps = 1,
	
        /// <summary>
        /// Audit Components And Store Apps
        /// </summary>
        AuditComponentsAndStoreApps = 2,
	
        /// <summary>
        /// Enforce Components Store Apps And Smartlocker
        /// </summary>
        EnforceComponentsStoreAppsAndSmartlocker = 3,
	
        /// <summary>
        /// Audit Components Store Apps And Smartlocker
        /// </summary>
        AuditComponentsStoreAppsAndSmartlocker = 4,
	
    }
}
