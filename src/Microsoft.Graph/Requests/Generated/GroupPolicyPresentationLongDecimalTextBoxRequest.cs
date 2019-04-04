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
    /// The type GroupPolicyPresentationLongDecimalTextBoxRequest.
    /// </summary>
    public partial class GroupPolicyPresentationLongDecimalTextBoxRequest : BaseRequest, IGroupPolicyPresentationLongDecimalTextBoxRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyPresentationLongDecimalTextBoxRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyPresentationLongDecimalTextBoxRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationLongDecimalTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToCreate">The GroupPolicyPresentationLongDecimalTextBox to create.</param>
        /// <returns>The created GroupPolicyPresentationLongDecimalTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> CreateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToCreate)
        {
            return this.CreateAsync(groupPolicyPresentationLongDecimalTextBoxToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationLongDecimalTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToCreate">The GroupPolicyPresentationLongDecimalTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationLongDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> CreateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyPresentationLongDecimalTextBox>(groupPolicyPresentationLongDecimalTextBoxToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyPresentationLongDecimalTextBox>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationLongDecimalTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationLongDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyPresentationLongDecimalTextBox>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationLongDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToUpdate">The GroupPolicyPresentationLongDecimalTextBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationLongDecimalTextBox.</returns>
        public System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> UpdateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToUpdate)
        {
            return this.UpdateAsync(groupPolicyPresentationLongDecimalTextBoxToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationLongDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToUpdate">The GroupPolicyPresentationLongDecimalTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentationLongDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> UpdateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationLongDecimalTextBox>(groupPolicyPresentationLongDecimalTextBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationLongDecimalTextBoxRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationLongDecimalTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationLongDecimalTextBox, object>> expandExpression)
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
        public IGroupPolicyPresentationLongDecimalTextBoxRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationLongDecimalTextBoxRequest Select(Expression<Func<GroupPolicyPresentationLongDecimalTextBox, object>> selectExpression)
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
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToInitialize">The <see cref="GroupPolicyPresentationLongDecimalTextBox"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToInitialize)
        {

        }
    }
}
