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
    /// The type Workbook Chart Legend.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartLegend : Entity
    {
    
        /// <summary>
        /// Gets or sets overlay.
        /// Boolean value for whether the chart legend should overlap with the main body of the chart.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "overlay", Required = Newtonsoft.Json.Required.Default)]
        public bool? Overlay { get; set; }
    
        /// <summary>
        /// Gets or sets position.
        /// Represents the position of the legend on the chart. The possible values are: Top, Bottom, Left, Right, Corner, Custom.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "position", Required = Newtonsoft.Json.Required.Default)]
        public string Position { get; set; }
    
        /// <summary>
        /// Gets or sets visible.
        /// A boolean value the represents the visibility of a ChartLegend object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visible", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of a chart legend, which includes fill and font formatting. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartLegendFormat Format { get; set; }
    
    }
}

