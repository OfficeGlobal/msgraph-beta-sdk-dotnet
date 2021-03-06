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
    /// The type Planner Task Details.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerTaskDetails : PlannerDelta
    {
    
		///<summary>
		/// The PlannerTaskDetails constructor
		///</summary>
        public PlannerTaskDetails()
        {
            this.ODataType = "microsoft.graph.plannerTaskDetails";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Description of the task
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets preview type.
        /// This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewType", Required = Newtonsoft.Json.Required.Default)]
        public PlannerPreviewType? PreviewType { get; set; }
    
        /// <summary>
        /// Gets or sets references.
        /// The collection of references on the task.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "references", Required = Newtonsoft.Json.Required.Default)]
        public PlannerExternalReferences References { get; set; }
    
        /// <summary>
        /// Gets or sets checklist.
        /// The collection of checklist items on the task.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "checklist", Required = Newtonsoft.Json.Required.Default)]
        public PlannerChecklistItems Checklist { get; set; }
    
    }
}

