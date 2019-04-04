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
    /// The type IosEasEmailProfileConfigurationRequest.
    /// </summary>
    public partial class IosEasEmailProfileConfigurationRequest : BaseRequest, IIosEasEmailProfileConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosEasEmailProfileConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosEasEmailProfileConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using POST.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <returns>The created IosEasEmailProfileConfiguration.</returns>
        public System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> CreateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate)
        {
            return this.CreateAsync(iosEasEmailProfileConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using POST.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosEasEmailProfileConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> CreateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosEasEmailProfileConfiguration>(iosEasEmailProfileConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosEasEmailProfileConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <returns>The IosEasEmailProfileConfiguration.</returns>
        public System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosEasEmailProfileConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosEasEmailProfileConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <returns>The updated IosEasEmailProfileConfiguration.</returns>
        public System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> UpdateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate)
        {
            return this.UpdateAsync(iosEasEmailProfileConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosEasEmailProfileConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> UpdateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosEasEmailProfileConfiguration>(iosEasEmailProfileConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEasEmailProfileConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEasEmailProfileConfigurationRequest Expand(Expression<Func<IosEasEmailProfileConfiguration, object>> expandExpression)
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
        public IIosEasEmailProfileConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosEasEmailProfileConfigurationRequest Select(Expression<Func<IosEasEmailProfileConfiguration, object>> selectExpression)
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
        /// <param name="iosEasEmailProfileConfigurationToInitialize">The <see cref="IosEasEmailProfileConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToInitialize)
        {

        }
    }
}
