// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DimensionRequestBuilder.
    /// </summary>
    public partial class DimensionRequestBuilder : EntityRequestBuilder, IDimensionRequestBuilder
    {

        /// <summary>
        /// Constructs a new DimensionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DimensionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDimensionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDimensionRequest Request(IEnumerable<Option> options)
        {
            return new DimensionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DimensionValues.
        /// </summary>
        /// <returns>The <see cref="IDimensionDimensionValuesCollectionRequestBuilder"/>.</returns>
        public IDimensionDimensionValuesCollectionRequestBuilder DimensionValues
        {
            get
            {
                return new DimensionDimensionValuesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("dimensionValues"), this.Client);
            }
        }
    
    }
}
