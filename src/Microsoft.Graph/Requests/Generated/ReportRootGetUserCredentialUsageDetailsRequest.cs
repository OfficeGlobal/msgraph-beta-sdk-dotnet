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
    /// The type ReportRootGetUserCredentialUsageDetailsRequest.
    /// </summary>
    public partial class ReportRootGetUserCredentialUsageDetailsRequest : BaseRequest, IReportRootGetUserCredentialUsageDetailsRequest
    {
        /// <summary>
        /// Constructs a new ReportRootGetUserCredentialUsageDetailsRequest.
        /// </summary>
        public ReportRootGetUserCredentialUsageDetailsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> GetAsync(
            CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<ReportRootGetUserCredentialUsageDetailsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
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
        /// <param name="usercredentialusagedetails">The UserCredentialUsageDetails object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> PatchAsync(UserCredentialUsageDetails usercredentialusagedetails)
        {
            return this.PatchAsync(usercredentialusagedetails, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="usercredentialusagedetails">The UserCredentialUsageDetails object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> PatchAsync(UserCredentialUsageDetails usercredentialusagedetails, 
            CancellationToken cancellationToken)
        {
            this.Method = "PATCH";
            var response = await this.SendAsync<ReportRootGetUserCredentialUsageDetailsCollectionResponse>(usercredentialusagedetails, cancellationToken).ConfigureAwait(false);
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
        /// <param name="usercredentialusagedetails">The UserCredentialUsageDetails object to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> PutAsync(UserCredentialUsageDetails usercredentialusagedetails)
        {
            return this.PutAsync(usercredentialusagedetails, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="usercredentialusagedetails">The UserCredentialUsageDetails object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetUserCredentialUsageDetailsCollectionPage> PutAsync(UserCredentialUsageDetails usercredentialusagedetails, 
            CancellationToken cancellationToken)
        {
            this.Method = "PUT";
            var response = await this.SendAsync<ReportRootGetUserCredentialUsageDetailsCollectionResponse>(usercredentialusagedetails, cancellationToken).ConfigureAwait(false);
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
        public IReportRootGetUserCredentialUsageDetailsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetUserCredentialUsageDetailsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetUserCredentialUsageDetailsRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetUserCredentialUsageDetailsRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetUserCredentialUsageDetailsRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetUserCredentialUsageDetailsRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
