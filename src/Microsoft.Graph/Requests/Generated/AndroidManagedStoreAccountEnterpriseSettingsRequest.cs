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
    /// The type AndroidManagedStoreAccountEnterpriseSettingsRequest.
    /// </summary>
    public partial class AndroidManagedStoreAccountEnterpriseSettingsRequest : BaseRequest, IAndroidManagedStoreAccountEnterpriseSettingsRequest
    {
        /// <summary>
        /// Constructs a new AndroidManagedStoreAccountEnterpriseSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidManagedStoreAccountEnterpriseSettingsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using POST.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <returns>The created AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> CreateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate)
        {
            return this.CreateAsync(androidManagedStoreAccountEnterpriseSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using POST.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> CreateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <returns>The AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <returns>The updated AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> UpdateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate)
        {
            return this.UpdateAsync(androidManagedStoreAccountEnterpriseSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> UpdateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData != null)
			{
				if (androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedStoreAccountEnterpriseSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData != null)
            {
                if (androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidManagedStoreAccountEnterpriseSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidManagedStoreAccountEnterpriseSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> expandExpression)
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
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> selectExpression)
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
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToInitialize">The <see cref="AndroidManagedStoreAccountEnterpriseSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToInitialize)
        {

        }
    }
}
