// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type RequestMyDecisionsCollectionRequestBuilder.
    /// </summary>
    public partial class RequestMyDecisionsCollectionRequestBuilder : BaseRequestBuilder, IRequestMyDecisionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new RequestMyDecisionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RequestMyDecisionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IRequestMyDecisionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IRequestMyDecisionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new RequestMyDecisionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessReviewDecisionRequestBuilder"/> for the specified RequestAccessReviewDecision.
        /// </summary>
        /// <param name="id">The ID for the RequestAccessReviewDecision.</param>
        /// <returns>The <see cref="IAccessReviewDecisionRequestBuilder"/>.</returns>
        public IAccessReviewDecisionRequestBuilder this[string id]
        {
            get
            {
                return new AccessReviewDecisionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
