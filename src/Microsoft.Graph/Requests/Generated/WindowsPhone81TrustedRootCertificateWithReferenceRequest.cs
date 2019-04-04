// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WindowsPhone81TrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial class WindowsPhone81TrustedRootCertificateWithReferenceRequest : BaseRequest, IWindowsPhone81TrustedRootCertificateWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new WindowsPhone81TrustedRootCertificateWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsPhone81TrustedRootCertificateWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <returns>The WindowsPhone81TrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81TrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsPhone81TrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified WindowsPhone81TrustedRootCertificate using POST.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToCreate">The WindowsPhone81TrustedRootCertificate to create.</param>
        /// <returns>The created WindowsPhone81TrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> CreateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToCreate)
        {
            return this.CreateAsync(windowsPhone81TrustedRootCertificateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsPhone81TrustedRootCertificate using POST.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToCreate">The WindowsPhone81TrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81TrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> CreateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsPhone81TrustedRootCertificate>(windowsPhone81TrustedRootCertificateToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified WindowsPhone81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToUpdate">The WindowsPhone81TrustedRootCertificate to update.</param>
        /// <returns>The updated WindowsPhone81TrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> UpdateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToUpdate)
        {
            return this.UpdateAsync(windowsPhone81TrustedRootCertificateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsPhone81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToUpdate">The WindowsPhone81TrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsPhone81TrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> UpdateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsPhone81TrustedRootCertificate>(windowsPhone81TrustedRootCertificateToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsPhone81TrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81TrustedRootCertificateWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81TrustedRootCertificateWithReferenceRequest Expand(Expression<Func<WindowsPhone81TrustedRootCertificate, object>> expandExpression)
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
        public IWindowsPhone81TrustedRootCertificateWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsPhone81TrustedRootCertificateWithReferenceRequest Select(Expression<Func<WindowsPhone81TrustedRootCertificate, object>> selectExpression)
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

    }
}
