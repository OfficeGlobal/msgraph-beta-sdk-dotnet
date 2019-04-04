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
    /// The type WindowsDeliveryOptimizationConfigurationRequest.
    /// </summary>
    public partial class WindowsDeliveryOptimizationConfigurationRequest : BaseRequest, IWindowsDeliveryOptimizationConfigurationRequest
    {
        /// <summary>
        /// Constructs a new WindowsDeliveryOptimizationConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsDeliveryOptimizationConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsDeliveryOptimizationConfiguration using POST.
        /// </summary>
        /// <param name="windowsDeliveryOptimizationConfigurationToCreate">The WindowsDeliveryOptimizationConfiguration to create.</param>
        /// <returns>The created WindowsDeliveryOptimizationConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> CreateAsync(WindowsDeliveryOptimizationConfiguration windowsDeliveryOptimizationConfigurationToCreate)
        {
            return this.CreateAsync(windowsDeliveryOptimizationConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsDeliveryOptimizationConfiguration using POST.
        /// </summary>
        /// <param name="windowsDeliveryOptimizationConfigurationToCreate">The WindowsDeliveryOptimizationConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDeliveryOptimizationConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> CreateAsync(WindowsDeliveryOptimizationConfiguration windowsDeliveryOptimizationConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsDeliveryOptimizationConfiguration>(windowsDeliveryOptimizationConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WindowsDeliveryOptimizationConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsDeliveryOptimizationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsDeliveryOptimizationConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsDeliveryOptimizationConfiguration.
        /// </summary>
        /// <returns>The WindowsDeliveryOptimizationConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsDeliveryOptimizationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDeliveryOptimizationConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsDeliveryOptimizationConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsDeliveryOptimizationConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsDeliveryOptimizationConfigurationToUpdate">The WindowsDeliveryOptimizationConfiguration to update.</param>
        /// <returns>The updated WindowsDeliveryOptimizationConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> UpdateAsync(WindowsDeliveryOptimizationConfiguration windowsDeliveryOptimizationConfigurationToUpdate)
        {
            return this.UpdateAsync(windowsDeliveryOptimizationConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsDeliveryOptimizationConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsDeliveryOptimizationConfigurationToUpdate">The WindowsDeliveryOptimizationConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsDeliveryOptimizationConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDeliveryOptimizationConfiguration> UpdateAsync(WindowsDeliveryOptimizationConfiguration windowsDeliveryOptimizationConfigurationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsDeliveryOptimizationConfiguration>(windowsDeliveryOptimizationConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDeliveryOptimizationConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDeliveryOptimizationConfigurationRequest Expand(Expression<Func<WindowsDeliveryOptimizationConfiguration, object>> expandExpression)
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
        public IWindowsDeliveryOptimizationConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDeliveryOptimizationConfigurationRequest Select(Expression<Func<WindowsDeliveryOptimizationConfiguration, object>> selectExpression)
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
        /// <param name="windowsDeliveryOptimizationConfigurationToInitialize">The <see cref="WindowsDeliveryOptimizationConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsDeliveryOptimizationConfiguration windowsDeliveryOptimizationConfigurationToInitialize)
        {

        }
    }
}
