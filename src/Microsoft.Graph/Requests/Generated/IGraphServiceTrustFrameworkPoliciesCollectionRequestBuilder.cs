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
    /// The interface IGraphServiceTrustFrameworkPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceTrustFrameworkPoliciesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceTrustFrameworkPoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceTrustFrameworkPoliciesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ITrustFrameworkPolicyRequestBuilder"/> for the specified TrustFrameworkPolicy.
        /// </summary>
        /// <param name="id">The ID for the TrustFrameworkPolicy.</param>
        /// <returns>The <see cref="ITrustFrameworkPolicyRequestBuilder"/>.</returns>
        ITrustFrameworkPolicyRequestBuilder this[string id] { get; }

        
    }
}
