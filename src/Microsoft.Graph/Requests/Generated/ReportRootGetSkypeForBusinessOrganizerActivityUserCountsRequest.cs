// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest.
    /// </summary>
    public partial class ReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest : BaseRequest, IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest
    {
        /// <summary>
        /// Constructs a new ReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest.
        /// </summary>
        public ReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="skypeforbusinessorganizeractivityusercounts">The SkypeForBusinessOrganizerActivityUserCounts object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> PatchAsync(SkypeForBusinessOrganizerActivityUserCounts skypeforbusinessorganizeractivityusercounts)
        {
            return this.PatchAsync(skypeforbusinessorganizeractivityusercounts, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="skypeforbusinessorganizeractivityusercounts">The SkypeForBusinessOrganizerActivityUserCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> PatchAsync(SkypeForBusinessOrganizerActivityUserCounts skypeforbusinessorganizeractivityusercounts, 
            CancellationToken cancellationToken)
        {
            this.Method = "PATCH";
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionResponse>(skypeforbusinessorganizeractivityusercounts, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }        

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="skypeforbusinessorganizeractivityusercounts">The SkypeForBusinessOrganizerActivityUserCounts object to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> PutAsync(SkypeForBusinessOrganizerActivityUserCounts skypeforbusinessorganizeractivityusercounts)
        {
            return this.PutAsync(skypeforbusinessorganizeractivityusercounts, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="skypeforbusinessorganizeractivityusercounts">The SkypeForBusinessOrganizerActivityUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionPage> PutAsync(SkypeForBusinessOrganizerActivityUserCounts skypeforbusinessorganizeractivityusercounts, 
            CancellationToken cancellationToken)
        {
            this.Method = "PUT";
            var response = await this.SendAsync<ReportRootGetSkypeForBusinessOrganizerActivityUserCountsCollectionResponse>(skypeforbusinessorganizeractivityusercounts, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }        

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetSkypeForBusinessOrganizerActivityUserCountsRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
