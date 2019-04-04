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
    /// The type SynchronizationJobRequest.
    /// </summary>
    public partial class SynchronizationJobRequest : BaseRequest, ISynchronizationJobRequest
    {
        /// <summary>
        /// Constructs a new SynchronizationJobRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SynchronizationJobRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SynchronizationJob using POST.
        /// </summary>
        /// <param name="synchronizationJobToCreate">The SynchronizationJob to create.</param>
        /// <returns>The created SynchronizationJob.</returns>
        public System.Threading.Tasks.Task<SynchronizationJob> CreateAsync(SynchronizationJob synchronizationJobToCreate)
        {
            return this.CreateAsync(synchronizationJobToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SynchronizationJob using POST.
        /// </summary>
        /// <param name="synchronizationJobToCreate">The SynchronizationJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SynchronizationJob.</returns>
        public async System.Threading.Tasks.Task<SynchronizationJob> CreateAsync(SynchronizationJob synchronizationJobToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SynchronizationJob>(synchronizationJobToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified SynchronizationJob.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SynchronizationJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SynchronizationJob>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SynchronizationJob.
        /// </summary>
        /// <returns>The SynchronizationJob.</returns>
        public System.Threading.Tasks.Task<SynchronizationJob> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SynchronizationJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SynchronizationJob.</returns>
        public async System.Threading.Tasks.Task<SynchronizationJob> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SynchronizationJob>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified SynchronizationJob using PATCH.
        /// </summary>
        /// <param name="synchronizationJobToUpdate">The SynchronizationJob to update.</param>
        /// <returns>The updated SynchronizationJob.</returns>
        public System.Threading.Tasks.Task<SynchronizationJob> UpdateAsync(SynchronizationJob synchronizationJobToUpdate)
        {
            return this.UpdateAsync(synchronizationJobToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SynchronizationJob using PATCH.
        /// </summary>
        /// <param name="synchronizationJobToUpdate">The SynchronizationJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SynchronizationJob.</returns>
        public async System.Threading.Tasks.Task<SynchronizationJob> UpdateAsync(SynchronizationJob synchronizationJobToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SynchronizationJob>(synchronizationJobToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationJobRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationJobRequest Expand(Expression<Func<SynchronizationJob, object>> expandExpression)
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
        public ISynchronizationJobRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationJobRequest Select(Expression<Func<SynchronizationJob, object>> selectExpression)
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
        /// <param name="synchronizationJobToInitialize">The <see cref="SynchronizationJob"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SynchronizationJob synchronizationJobToInitialize)
        {

        }
    }
}
