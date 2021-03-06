// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceRiskDetectionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceRiskDetectionsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceRiskDetectionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceRiskDetectionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IRiskDetectionRequestBuilder"/> for the specified RiskDetection.
        /// </summary>
        /// <param name="id">The ID for the RiskDetection.</param>
        /// <returns>The <see cref="IRiskDetectionRequestBuilder"/>.</returns>
        IRiskDetectionRequestBuilder this[string id] { get; }

        
    }
}
