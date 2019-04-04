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
    /// The type OrgContactRequest.
    /// </summary>
    public partial class OrgContactRequest : BaseRequest, IOrgContactRequest
    {
        /// <summary>
        /// Constructs a new OrgContactRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OrgContactRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OrgContact using POST.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <returns>The created OrgContact.</returns>
        public System.Threading.Tasks.Task<OrgContact> CreateAsync(OrgContact orgContactToCreate)
        {
            return this.CreateAsync(orgContactToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OrgContact using POST.
        /// </summary>
        /// <param name="orgContactToCreate">The OrgContact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrgContact.</returns>
        public async System.Threading.Tasks.Task<OrgContact> CreateAsync(OrgContact orgContactToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OrgContact>(orgContactToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified OrgContact.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OrgContact>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OrgContact.
        /// </summary>
        /// <returns>The OrgContact.</returns>
        public System.Threading.Tasks.Task<OrgContact> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OrgContact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrgContact.</returns>
        public async System.Threading.Tasks.Task<OrgContact> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OrgContact>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OrgContact using PATCH.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <returns>The updated OrgContact.</returns>
        public System.Threading.Tasks.Task<OrgContact> UpdateAsync(OrgContact orgContactToUpdate)
        {
            return this.UpdateAsync(orgContactToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OrgContact using PATCH.
        /// </summary>
        /// <param name="orgContactToUpdate">The OrgContact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OrgContact.</returns>
        public async System.Threading.Tasks.Task<OrgContact> UpdateAsync(OrgContact orgContactToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OrgContact>(orgContactToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrgContactRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrgContactRequest Expand(Expression<Func<OrgContact, object>> expandExpression)
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
        public IOrgContactRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrgContactRequest Select(Expression<Func<OrgContact, object>> selectExpression)
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
        /// <param name="orgContactToInitialize">The <see cref="OrgContact"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OrgContact orgContactToInitialize)
        {

            if (orgContactToInitialize != null && orgContactToInitialize.AdditionalData != null)
            {

                if (orgContactToInitialize.DirectReports != null && orgContactToInitialize.DirectReports.CurrentPage != null)
                {
                    orgContactToInitialize.DirectReports.AdditionalData = orgContactToInitialize.AdditionalData;

                    object nextPageLink;
                    orgContactToInitialize.AdditionalData.TryGetValue("directReports@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        orgContactToInitialize.DirectReports.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (orgContactToInitialize.MemberOf != null && orgContactToInitialize.MemberOf.CurrentPage != null)
                {
                    orgContactToInitialize.MemberOf.AdditionalData = orgContactToInitialize.AdditionalData;

                    object nextPageLink;
                    orgContactToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        orgContactToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (orgContactToInitialize.TransitiveMemberOf != null && orgContactToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    orgContactToInitialize.TransitiveMemberOf.AdditionalData = orgContactToInitialize.AdditionalData;

                    object nextPageLink;
                    orgContactToInitialize.AdditionalData.TryGetValue("transitiveMemberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        orgContactToInitialize.TransitiveMemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
