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
    /// The type DeviceConfigurationDeviceStatusRequest.
    /// </summary>
    public partial class DeviceConfigurationDeviceStatusRequest : BaseRequest, IDeviceConfigurationDeviceStatusRequest
    {
        /// <summary>
        /// Constructs a new DeviceConfigurationDeviceStatusRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceConfigurationDeviceStatusRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStatus using POST.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToCreate">The DeviceConfigurationDeviceStatus to create.</param>
        /// <returns>The created DeviceConfigurationDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> CreateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToCreate)
        {
            return this.CreateAsync(deviceConfigurationDeviceStatusToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStatus using POST.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToCreate">The DeviceConfigurationDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> CreateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceConfigurationDeviceStatus>(deviceConfigurationDeviceStatusToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceConfigurationDeviceStatus>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <returns>The DeviceConfigurationDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceConfigurationDeviceStatus>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus to update.</param>
        /// <returns>The updated DeviceConfigurationDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> UpdateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate)
        {
            return this.UpdateAsync(deviceConfigurationDeviceStatusToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfigurationDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> UpdateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceConfigurationDeviceStatus>(deviceConfigurationDeviceStatusToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationDeviceStatusRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationDeviceStatusRequest Expand(Expression<Func<DeviceConfigurationDeviceStatus, object>> expandExpression)
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
        public IDeviceConfigurationDeviceStatusRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationDeviceStatusRequest Select(Expression<Func<DeviceConfigurationDeviceStatus, object>> selectExpression)
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
        /// <param name="deviceConfigurationDeviceStatusToInitialize">The <see cref="DeviceConfigurationDeviceStatus"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToInitialize)
        {

        }
    }
}
