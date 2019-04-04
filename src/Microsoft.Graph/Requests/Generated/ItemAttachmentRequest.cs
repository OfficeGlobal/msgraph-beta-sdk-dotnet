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
    /// The type ItemAttachmentRequest.
    /// </summary>
    public partial class ItemAttachmentRequest : BaseRequest, IItemAttachmentRequest
    {
        /// <summary>
        /// Constructs a new ItemAttachmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ItemAttachmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ItemAttachment using POST.
        /// </summary>
        /// <param name="itemAttachmentToCreate">The ItemAttachment to create.</param>
        /// <returns>The created ItemAttachment.</returns>
        public System.Threading.Tasks.Task<ItemAttachment> CreateAsync(ItemAttachment itemAttachmentToCreate)
        {
            return this.CreateAsync(itemAttachmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ItemAttachment using POST.
        /// </summary>
        /// <param name="itemAttachmentToCreate">The ItemAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAttachment.</returns>
        public async System.Threading.Tasks.Task<ItemAttachment> CreateAsync(ItemAttachment itemAttachmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ItemAttachment>(itemAttachmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ItemAttachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ItemAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ItemAttachment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ItemAttachment.
        /// </summary>
        /// <returns>The ItemAttachment.</returns>
        public System.Threading.Tasks.Task<ItemAttachment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ItemAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAttachment.</returns>
        public async System.Threading.Tasks.Task<ItemAttachment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ItemAttachment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ItemAttachment using PATCH.
        /// </summary>
        /// <param name="itemAttachmentToUpdate">The ItemAttachment to update.</param>
        /// <returns>The updated ItemAttachment.</returns>
        public System.Threading.Tasks.Task<ItemAttachment> UpdateAsync(ItemAttachment itemAttachmentToUpdate)
        {
            return this.UpdateAsync(itemAttachmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ItemAttachment using PATCH.
        /// </summary>
        /// <param name="itemAttachmentToUpdate">The ItemAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ItemAttachment.</returns>
        public async System.Threading.Tasks.Task<ItemAttachment> UpdateAsync(ItemAttachment itemAttachmentToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ItemAttachment>(itemAttachmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAttachmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAttachmentRequest Expand(Expression<Func<ItemAttachment, object>> expandExpression)
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
        public IItemAttachmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAttachmentRequest Select(Expression<Func<ItemAttachment, object>> selectExpression)
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
        /// <param name="itemAttachmentToInitialize">The <see cref="ItemAttachment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ItemAttachment itemAttachmentToInitialize)
        {

        }
    }
}
