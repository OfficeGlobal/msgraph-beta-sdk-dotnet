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
    /// The type UserSecurityProfileRequest.
    /// </summary>
    public partial class UserSecurityProfileRequest : BaseRequest, IUserSecurityProfileRequest
    {
        /// <summary>
        /// Constructs a new UserSecurityProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserSecurityProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserSecurityProfile using POST.
        /// </summary>
        /// <param name="userSecurityProfileToCreate">The UserSecurityProfile to create.</param>
        /// <returns>The created UserSecurityProfile.</returns>
        public System.Threading.Tasks.Task<UserSecurityProfile> CreateAsync(UserSecurityProfile userSecurityProfileToCreate)
        {
            return this.CreateAsync(userSecurityProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserSecurityProfile using POST.
        /// </summary>
        /// <param name="userSecurityProfileToCreate">The UserSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserSecurityProfile.</returns>
        public async System.Threading.Tasks.Task<UserSecurityProfile> CreateAsync(UserSecurityProfile userSecurityProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UserSecurityProfile>(userSecurityProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified UserSecurityProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UserSecurityProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UserSecurityProfile.
        /// </summary>
        /// <returns>The UserSecurityProfile.</returns>
        public System.Threading.Tasks.Task<UserSecurityProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserSecurityProfile.</returns>
        public async System.Threading.Tasks.Task<UserSecurityProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UserSecurityProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UserSecurityProfile using PATCH.
        /// </summary>
        /// <param name="userSecurityProfileToUpdate">The UserSecurityProfile to update.</param>
        /// <returns>The updated UserSecurityProfile.</returns>
        public System.Threading.Tasks.Task<UserSecurityProfile> UpdateAsync(UserSecurityProfile userSecurityProfileToUpdate)
        {
            return this.UpdateAsync(userSecurityProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserSecurityProfile using PATCH.
        /// </summary>
        /// <param name="userSecurityProfileToUpdate">The UserSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated UserSecurityProfile.</returns>
        public async System.Threading.Tasks.Task<UserSecurityProfile> UpdateAsync(UserSecurityProfile userSecurityProfileToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UserSecurityProfile>(userSecurityProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserSecurityProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserSecurityProfileRequest Expand(Expression<Func<UserSecurityProfile, object>> expandExpression)
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
        public IUserSecurityProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserSecurityProfileRequest Select(Expression<Func<UserSecurityProfile, object>> selectExpression)
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
        /// <param name="userSecurityProfileToInitialize">The <see cref="UserSecurityProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserSecurityProfile userSecurityProfileToInitialize)
        {

        }
    }
}
