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
    /// The type DirectoryRoleRequest.
    /// </summary>
    public partial class DirectoryRoleRequest : BaseRequest, IDirectoryRoleRequest
    {
        /// <summary>
        /// Constructs a new DirectoryRoleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DirectoryRoleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DirectoryRole using POST.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <returns>The created DirectoryRole.</returns>
        public System.Threading.Tasks.Task<DirectoryRole> CreateAsync(DirectoryRole directoryRoleToCreate)
        {
            return this.CreateAsync(directoryRoleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DirectoryRole using POST.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRole.</returns>
        public async System.Threading.Tasks.Task<DirectoryRole> CreateAsync(DirectoryRole directoryRoleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DirectoryRole>(directoryRoleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DirectoryRole.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DirectoryRole>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <returns>The DirectoryRole.</returns>
        public System.Threading.Tasks.Task<DirectoryRole> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryRole.</returns>
        public async System.Threading.Tasks.Task<DirectoryRole> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DirectoryRole>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <returns>The updated DirectoryRole.</returns>
        public System.Threading.Tasks.Task<DirectoryRole> UpdateAsync(DirectoryRole directoryRoleToUpdate)
        {
            return this.UpdateAsync(directoryRoleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectoryRole.</returns>
        public async System.Threading.Tasks.Task<DirectoryRole> UpdateAsync(DirectoryRole directoryRoleToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DirectoryRole>(directoryRoleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRoleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRoleRequest Expand(Expression<Func<DirectoryRole, object>> expandExpression)
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
        public IDirectoryRoleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRoleRequest Select(Expression<Func<DirectoryRole, object>> selectExpression)
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
        /// <param name="directoryRoleToInitialize">The <see cref="DirectoryRole"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DirectoryRole directoryRoleToInitialize)
        {

            if (directoryRoleToInitialize != null && directoryRoleToInitialize.AdditionalData != null)
            {

                if (directoryRoleToInitialize.Members != null && directoryRoleToInitialize.Members.CurrentPage != null)
                {
                    directoryRoleToInitialize.Members.AdditionalData = directoryRoleToInitialize.AdditionalData;

                    object nextPageLink;
                    directoryRoleToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        directoryRoleToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (directoryRoleToInitialize.ScopedMembers != null && directoryRoleToInitialize.ScopedMembers.CurrentPage != null)
                {
                    directoryRoleToInitialize.ScopedMembers.AdditionalData = directoryRoleToInitialize.AdditionalData;

                    object nextPageLink;
                    directoryRoleToInitialize.AdditionalData.TryGetValue("scopedMembers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        directoryRoleToInitialize.ScopedMembers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
