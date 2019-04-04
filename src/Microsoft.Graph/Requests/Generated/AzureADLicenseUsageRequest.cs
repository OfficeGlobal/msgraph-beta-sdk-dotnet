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
    /// The type AzureADLicenseUsageRequest.
    /// </summary>
    public partial class AzureADLicenseUsageRequest : BaseRequest, IAzureADLicenseUsageRequest
    {
        /// <summary>
        /// Constructs a new AzureADLicenseUsageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AzureADLicenseUsageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AzureADLicenseUsage using POST.
        /// </summary>
        /// <param name="azureADLicenseUsageToCreate">The AzureADLicenseUsage to create.</param>
        /// <returns>The created AzureADLicenseUsage.</returns>
        public System.Threading.Tasks.Task<AzureADLicenseUsage> CreateAsync(AzureADLicenseUsage azureADLicenseUsageToCreate)
        {
            return this.CreateAsync(azureADLicenseUsageToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AzureADLicenseUsage using POST.
        /// </summary>
        /// <param name="azureADLicenseUsageToCreate">The AzureADLicenseUsage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AzureADLicenseUsage.</returns>
        public async System.Threading.Tasks.Task<AzureADLicenseUsage> CreateAsync(AzureADLicenseUsage azureADLicenseUsageToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AzureADLicenseUsage>(azureADLicenseUsageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AzureADLicenseUsage.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AzureADLicenseUsage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AzureADLicenseUsage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AzureADLicenseUsage.
        /// </summary>
        /// <returns>The AzureADLicenseUsage.</returns>
        public System.Threading.Tasks.Task<AzureADLicenseUsage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AzureADLicenseUsage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AzureADLicenseUsage.</returns>
        public async System.Threading.Tasks.Task<AzureADLicenseUsage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AzureADLicenseUsage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AzureADLicenseUsage using PATCH.
        /// </summary>
        /// <param name="azureADLicenseUsageToUpdate">The AzureADLicenseUsage to update.</param>
        /// <returns>The updated AzureADLicenseUsage.</returns>
        public System.Threading.Tasks.Task<AzureADLicenseUsage> UpdateAsync(AzureADLicenseUsage azureADLicenseUsageToUpdate)
        {
            return this.UpdateAsync(azureADLicenseUsageToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AzureADLicenseUsage using PATCH.
        /// </summary>
        /// <param name="azureADLicenseUsageToUpdate">The AzureADLicenseUsage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AzureADLicenseUsage.</returns>
        public async System.Threading.Tasks.Task<AzureADLicenseUsage> UpdateAsync(AzureADLicenseUsage azureADLicenseUsageToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AzureADLicenseUsage>(azureADLicenseUsageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADLicenseUsageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADLicenseUsageRequest Expand(Expression<Func<AzureADLicenseUsage, object>> expandExpression)
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
        public IAzureADLicenseUsageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAzureADLicenseUsageRequest Select(Expression<Func<AzureADLicenseUsage, object>> selectExpression)
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
        /// <param name="azureADLicenseUsageToInitialize">The <see cref="AzureADLicenseUsage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AzureADLicenseUsage azureADLicenseUsageToInitialize)
        {

        }
    }
}
