// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AndroidMobileAppIdentifier.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidMobileAppIdentifier : MobileAppIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidMobileAppIdentifier"/> class.
        /// </summary>
        public AndroidMobileAppIdentifier()
        {
            this.ODataType = "microsoft.graph.androidMobileAppIdentifier";
        }

        /// <summary>
        /// Gets or sets packageId.
        /// The identifier for an app, as specified in the play store.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageId", Required = Newtonsoft.Json.Required.Default)]
        public string PackageId { get; set; }
    
    }
}
