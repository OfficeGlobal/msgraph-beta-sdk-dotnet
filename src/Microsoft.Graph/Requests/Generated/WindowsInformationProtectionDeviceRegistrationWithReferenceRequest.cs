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
    /// The type WindowsInformationProtectionDeviceRegistrationWithReferenceRequest.
    /// </summary>
    public partial class WindowsInformationProtectionDeviceRegistrationWithReferenceRequest : BaseRequest, IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionDeviceRegistrationWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsInformationProtectionDeviceRegistrationWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <returns>The WindowsInformationProtectionDeviceRegistration.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified WindowsInformationProtectionDeviceRegistration using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToCreate">The WindowsInformationProtectionDeviceRegistration to create.</param>
        /// <returns>The created WindowsInformationProtectionDeviceRegistration.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> CreateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToCreate)
        {
            return this.CreateAsync(windowsInformationProtectionDeviceRegistrationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsInformationProtectionDeviceRegistration using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToCreate">The WindowsInformationProtectionDeviceRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> CreateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration to update.</param>
        /// <returns>The updated WindowsInformationProtectionDeviceRegistration.</returns>
        public System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> UpdateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate)
        {
            return this.UpdateAsync(windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsInformationProtectionDeviceRegistration using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionDeviceRegistrationToUpdate">The WindowsInformationProtectionDeviceRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsInformationProtectionDeviceRegistration.</returns>
        public async System.Threading.Tasks.Task<WindowsInformationProtectionDeviceRegistration> UpdateAsync(WindowsInformationProtectionDeviceRegistration windowsInformationProtectionDeviceRegistrationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(windowsInformationProtectionDeviceRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsInformationProtectionDeviceRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Expand(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> expandExpression)
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
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Select(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> selectExpression)
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
