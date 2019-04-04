// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementDeviceManagementScriptsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceManagementScriptsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceManagementScriptsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceManagementScriptsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceManagementScriptsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceManagementScriptsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceManagementScriptsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceManagementScriptsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptRequestBuilder"/> for the specified DeviceManagementDeviceManagementScript.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceManagementScript.</param>
        /// <returns>The <see cref="IDeviceManagementScriptRequestBuilder"/>.</returns>
        public IDeviceManagementScriptRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementScriptRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
