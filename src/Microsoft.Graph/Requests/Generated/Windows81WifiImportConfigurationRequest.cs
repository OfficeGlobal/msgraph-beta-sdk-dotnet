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
    /// The type Windows81WifiImportConfigurationRequest.
    /// </summary>
    public partial class Windows81WifiImportConfigurationRequest : BaseRequest, IWindows81WifiImportConfigurationRequest
    {
        /// <summary>
        /// Constructs a new Windows81WifiImportConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows81WifiImportConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <returns>The created Windows81WifiImportConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows81WifiImportConfiguration> CreateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate)
        {
            return this.CreateAsync(windows81WifiImportConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81WifiImportConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows81WifiImportConfiguration> CreateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows81WifiImportConfiguration>(windows81WifiImportConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows81WifiImportConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <returns>The Windows81WifiImportConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows81WifiImportConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81WifiImportConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows81WifiImportConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows81WifiImportConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <returns>The updated Windows81WifiImportConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows81WifiImportConfiguration> UpdateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate)
        {
            return this.UpdateAsync(windows81WifiImportConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Windows81WifiImportConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows81WifiImportConfiguration> UpdateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows81WifiImportConfiguration>(windows81WifiImportConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81WifiImportConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81WifiImportConfigurationRequest Expand(Expression<Func<Windows81WifiImportConfiguration, object>> expandExpression)
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
        public IWindows81WifiImportConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows81WifiImportConfigurationRequest Select(Expression<Func<Windows81WifiImportConfiguration, object>> selectExpression)
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
        /// <param name="windows81WifiImportConfigurationToInitialize">The <see cref="Windows81WifiImportConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows81WifiImportConfiguration windows81WifiImportConfigurationToInitialize)
        {

        }
    }
}
