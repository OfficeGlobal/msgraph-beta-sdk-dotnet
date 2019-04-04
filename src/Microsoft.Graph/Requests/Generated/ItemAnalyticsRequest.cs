// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ItemAnalyticsRequest.
    /// </summary>
    public partial class ItemAnalyticsRequest : BaseRequest, IItemAnalyticsRequest
    {
        /// <summary>
        /// Constructs a new ItemAnalyticsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ItemAnalyticsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ItemAnalytics using POST.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <returns>The created ItemAnalytics.</returns>
        public System.Threading.Tasks.Task<ItemAnalytics> CreateAsync(ItemAnalytics itemAnalyticsToCreate)
        {
            return this.CreateAsync(itemAnalyticsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ItemAnalytics using POST.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> CreateAsync(ItemAnalytics itemAnalyticsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ItemAnalytics>(itemAnalyticsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ItemAnalytics.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ItemAnalytics>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ItemAnalytics.
        /// </summary>
        /// <returns>The ItemAnalytics.</returns>
        public System.Threading.Tasks.Task<ItemAnalytics> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ItemAnalytics>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <returns>The updated ItemAnalytics.</returns>
        public System.Threading.Tasks.Task<ItemAnalytics> UpdateAsync(ItemAnalytics itemAnalyticsToUpdate)
        {
            return this.UpdateAsync(itemAnalyticsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> UpdateAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ItemAnalytics>(itemAnalyticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Expand(Expression<Func<ItemAnalytics, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Select(Expression<Func<ItemAnalytics, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="itemAnalyticsToInitialize">The <see cref="ItemAnalytics"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ItemAnalytics itemAnalyticsToInitialize)
        {

            if (itemAnalyticsToInitialize != null && itemAnalyticsToInitialize.AdditionalData != null)
            {

                if (itemAnalyticsToInitialize.ItemActivityStats != null && itemAnalyticsToInitialize.ItemActivityStats.CurrentPage != null)
                {
                    itemAnalyticsToInitialize.ItemActivityStats.AdditionalData = itemAnalyticsToInitialize.AdditionalData;

                    object nextPageLink;
                    itemAnalyticsToInitialize.AdditionalData.TryGetValue("itemActivityStats@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        itemAnalyticsToInitialize.ItemActivityStats.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
