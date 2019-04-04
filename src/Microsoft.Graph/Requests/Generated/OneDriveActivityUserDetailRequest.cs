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
    /// The type OneDriveActivityUserDetailRequest.
    /// </summary>
    public partial class OneDriveActivityUserDetailRequest : BaseRequest, IOneDriveActivityUserDetailRequest
    {
        /// <summary>
        /// Constructs a new OneDriveActivityUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OneDriveActivityUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OneDriveActivityUserDetail using POST.
        /// </summary>
        /// <param name="oneDriveActivityUserDetailToCreate">The OneDriveActivityUserDetail to create.</param>
        /// <returns>The created OneDriveActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<OneDriveActivityUserDetail> CreateAsync(OneDriveActivityUserDetail oneDriveActivityUserDetailToCreate)
        {
            return this.CreateAsync(oneDriveActivityUserDetailToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OneDriveActivityUserDetail using POST.
        /// </summary>
        /// <param name="oneDriveActivityUserDetailToCreate">The OneDriveActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OneDriveActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveActivityUserDetail> CreateAsync(OneDriveActivityUserDetail oneDriveActivityUserDetailToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OneDriveActivityUserDetail>(oneDriveActivityUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified OneDriveActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OneDriveActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OneDriveActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OneDriveActivityUserDetail.
        /// </summary>
        /// <returns>The OneDriveActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<OneDriveActivityUserDetail> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OneDriveActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OneDriveActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveActivityUserDetail> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OneDriveActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OneDriveActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="oneDriveActivityUserDetailToUpdate">The OneDriveActivityUserDetail to update.</param>
        /// <returns>The updated OneDriveActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<OneDriveActivityUserDetail> UpdateAsync(OneDriveActivityUserDetail oneDriveActivityUserDetailToUpdate)
        {
            return this.UpdateAsync(oneDriveActivityUserDetailToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OneDriveActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="oneDriveActivityUserDetailToUpdate">The OneDriveActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OneDriveActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<OneDriveActivityUserDetail> UpdateAsync(OneDriveActivityUserDetail oneDriveActivityUserDetailToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OneDriveActivityUserDetail>(oneDriveActivityUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveActivityUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveActivityUserDetailRequest Expand(Expression<Func<OneDriveActivityUserDetail, object>> expandExpression)
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
        public IOneDriveActivityUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOneDriveActivityUserDetailRequest Select(Expression<Func<OneDriveActivityUserDetail, object>> selectExpression)
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
        /// <param name="oneDriveActivityUserDetailToInitialize">The <see cref="OneDriveActivityUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OneDriveActivityUserDetail oneDriveActivityUserDetailToInitialize)
        {

        }
    }
}
