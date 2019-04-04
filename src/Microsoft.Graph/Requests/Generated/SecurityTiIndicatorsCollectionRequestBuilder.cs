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
    /// The type SecurityTiIndicatorsCollectionRequestBuilder.
    /// </summary>
    public partial class SecurityTiIndicatorsCollectionRequestBuilder : BaseRequestBuilder, ISecurityTiIndicatorsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SecurityTiIndicatorsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityTiIndicatorsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISecurityTiIndicatorsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISecurityTiIndicatorsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SecurityTiIndicatorsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITiIndicatorRequestBuilder"/> for the specified SecurityTiIndicator.
        /// </summary>
        /// <param name="id">The ID for the SecurityTiIndicator.</param>
        /// <returns>The <see cref="ITiIndicatorRequestBuilder"/>.</returns>
        public ITiIndicatorRequestBuilder this[string id]
        {
            get
            {
                return new TiIndicatorRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TiIndicatorSubmitTiIndicators.
        /// </summary>
        /// <returns>The <see cref="ITiIndicatorSubmitTiIndicatorsRequestBuilder"/>.</returns>
        public ITiIndicatorSubmitTiIndicatorsRequestBuilder SubmitTiIndicators(
            IEnumerable<TiIndicator> value = null)
        {
            return new TiIndicatorSubmitTiIndicatorsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.submitTiIndicators"),
                this.Client,
                value);
        }

        /// <summary>
        /// Gets the request builder for TiIndicatorUpdateTiIndicators.
        /// </summary>
        /// <returns>The <see cref="ITiIndicatorUpdateTiIndicatorsRequestBuilder"/>.</returns>
        public ITiIndicatorUpdateTiIndicatorsRequestBuilder UpdateTiIndicators(
            IEnumerable<TiIndicator> value = null)
        {
            return new TiIndicatorUpdateTiIndicatorsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateTiIndicators"),
                this.Client,
                value);
        }

        /// <summary>
        /// Gets the request builder for TiIndicatorDeleteTiIndicators.
        /// </summary>
        /// <returns>The <see cref="ITiIndicatorDeleteTiIndicatorsRequestBuilder"/>.</returns>
        public ITiIndicatorDeleteTiIndicatorsRequestBuilder DeleteTiIndicators(
            IEnumerable<string> value = null)
        {
            return new TiIndicatorDeleteTiIndicatorsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.deleteTiIndicators"),
                this.Client,
                value);
        }

        /// <summary>
        /// Gets the request builder for TiIndicatorDeleteTiIndicatorsByExternalId.
        /// </summary>
        /// <returns>The <see cref="ITiIndicatorDeleteTiIndicatorsByExternalIdRequestBuilder"/>.</returns>
        public ITiIndicatorDeleteTiIndicatorsByExternalIdRequestBuilder DeleteTiIndicatorsByExternalId(
            IEnumerable<string> value = null)
        {
            return new TiIndicatorDeleteTiIndicatorsByExternalIdRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.deleteTiIndicatorsByExternalId"),
                this.Client,
                value);
        }
    }
}
