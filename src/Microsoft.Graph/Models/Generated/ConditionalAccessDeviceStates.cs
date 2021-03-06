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
    /// The type ConditionalAccessDeviceStates.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ConditionalAccessDeviceStates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessDeviceStates"/> class.
        /// </summary>
        public ConditionalAccessDeviceStates()
        {
            this.ODataType = "microsoft.graph.conditionalAccessDeviceStates";
        }

        /// <summary>
        /// Gets or sets includeStates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "includeStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> IncludeStates { get; set; }
    
        /// <summary>
        /// Gets or sets excludeStates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "excludeStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ExcludeStates { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
