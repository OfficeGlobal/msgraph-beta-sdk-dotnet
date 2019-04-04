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
    /// The type Workbook Chart Title.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartTitle : Entity
    {
    
        /// <summary>
        /// Gets or sets overlay.
        /// Boolean value representing if the chart title will overlay the chart or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overlay", Required = Newtonsoft.Json.Required.Default)]
        public bool? Overlay { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// Represents the title text of a chart.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets visible.
        /// A boolean value the represents the visibility of a chart title object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visible", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of a chart title, which includes fill and font formatting. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartTitleFormat Format { get; set; }
    
    }
}

