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
    /// The type TeamsUserActivityUserDetailRequest.
    /// </summary>
    public partial class TeamsUserActivityUserDetailRequest : BaseRequest, ITeamsUserActivityUserDetailRequest
    {
        /// <summary>
        /// Constructs a new TeamsUserActivityUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamsUserActivityUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserDetail using POST.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToCreate">The TeamsUserActivityUserDetail to create.</param>
        /// <returns>The created TeamsUserActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserDetail> CreateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToCreate)
        {
            return this.CreateAsync(teamsUserActivityUserDetailToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TeamsUserActivityUserDetail using POST.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToCreate">The TeamsUserActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserDetail> CreateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TeamsUserActivityUserDetail>(teamsUserActivityUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TeamsUserActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <returns>The TeamsUserActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserDetail> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TeamsUserActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserDetail> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TeamsUserActivityUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToUpdate">The TeamsUserActivityUserDetail to update.</param>
        /// <returns>The updated TeamsUserActivityUserDetail.</returns>
        public System.Threading.Tasks.Task<TeamsUserActivityUserDetail> UpdateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToUpdate)
        {
            return this.UpdateAsync(teamsUserActivityUserDetailToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TeamsUserActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserDetailToUpdate">The TeamsUserActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TeamsUserActivityUserDetail.</returns>
        public async System.Threading.Tasks.Task<TeamsUserActivityUserDetail> UpdateAsync(TeamsUserActivityUserDetail teamsUserActivityUserDetailToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TeamsUserActivityUserDetail>(teamsUserActivityUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserDetailRequest Expand(Expression<Func<TeamsUserActivityUserDetail, object>> expandExpression)
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
        public ITeamsUserActivityUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamsUserActivityUserDetailRequest Select(Expression<Func<TeamsUserActivityUserDetail, object>> selectExpression)
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
        /// <param name="teamsUserActivityUserDetailToInitialize">The <see cref="TeamsUserActivityUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TeamsUserActivityUserDetail teamsUserActivityUserDetailToInitialize)
        {

        }
    }
}
