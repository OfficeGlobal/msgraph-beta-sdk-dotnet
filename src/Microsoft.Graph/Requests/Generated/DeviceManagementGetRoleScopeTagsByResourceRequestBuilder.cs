// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementGetRoleScopeTagsByResourceRequestBuilder.
    /// </summary>
    public partial class DeviceManagementGetRoleScopeTagsByResourceRequestBuilder : BaseFunctionMethodRequestBuilder<IDeviceManagementGetRoleScopeTagsByResourceRequest>, IDeviceManagementGetRoleScopeTagsByResourceRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementGetRoleScopeTagsByResourceRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="resource">A resource parameter for the OData method call.</param>
        public DeviceManagementGetRoleScopeTagsByResourceRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string resource)
            : base(requestUrl, client)
        {
            this.SetParameter("resource", resource, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementGetRoleScopeTagsByResourceRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementGetRoleScopeTagsByResourceRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
