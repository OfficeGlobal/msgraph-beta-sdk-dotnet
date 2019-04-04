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
    /// The type EmailActivityUserDetailRequest.
    /// </summary>
    public partial class EmailActivityUserDetailRequest : BaseRequest, IEmailActivityUserDetailRequest
    {
        /// <summary>
        /// Constructs a new EmailActivityUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmailActivityUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EmailActivityUserDetail using POST.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <returns>The created EmailActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<EmailActivityUserDetail> CreateAsync(EmailActivityUserDetail emailActivityUserDetailToCreate)
        {
            return this.CreateAsync(emailActivityUserDetailToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EmailActivityUserDetail using POST.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<EmailActivityUserDetail> CreateAsync(EmailActivityUserDetail emailActivityUserDetailToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EmailActivityUserDetail>(emailActivityUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EmailActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EmailActivityUserDetail.
        /// </summary>
        /// <returns>The EmailActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<EmailActivityUserDetail> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<EmailActivityUserDetail> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EmailActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <returns>The updated EmailActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<EmailActivityUserDetail> UpdateAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate)
        {
            return this.UpdateAsync(emailActivityUserDetailToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EmailActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<EmailActivityUserDetail> UpdateAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EmailActivityUserDetail>(emailActivityUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailActivityUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailActivityUserDetailRequest Expand(Expression<Func<EmailActivityUserDetail, object>> expandExpression)
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
        public IEmailActivityUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailActivityUserDetailRequest Select(Expression<Func<EmailActivityUserDetail, object>> selectExpression)
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
        /// <param name="emailActivityUserDetailToInitialize">The <see cref="EmailActivityUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EmailActivityUserDetail emailActivityUserDetailToInitialize)
        {

        }
    }
}
