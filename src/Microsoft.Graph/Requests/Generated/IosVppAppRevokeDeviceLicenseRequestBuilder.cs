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
    /// The type IosVppAppRevokeDeviceLicenseRequestBuilder.
    /// </summary>
    public partial class IosVppAppRevokeDeviceLicenseRequestBuilder : BaseActionMethodRequestBuilder<IIosVppAppRevokeDeviceLicenseRequest>, IIosVppAppRevokeDeviceLicenseRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="IosVppAppRevokeDeviceLicenseRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="notifyManagedDevices">A notifyManagedDevices parameter for the OData method call.</param>
        /// <param name="managedDeviceId">A managedDeviceId parameter for the OData method call.</param>
        public IosVppAppRevokeDeviceLicenseRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool notifyManagedDevices,
            string managedDeviceId)
            : base(requestUrl, client)
        {
            this.SetParameter("notifyManagedDevices", notifyManagedDevices, false);
            this.SetParameter("managedDeviceId", managedDeviceId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IIosVppAppRevokeDeviceLicenseRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new IosVppAppRevokeDeviceLicenseRequest(functionUrl, this.Client, options);

            if (this.HasParameter("notifyManagedDevices"))
            {
                request.RequestBody.NotifyManagedDevices = this.GetParameter<bool>("notifyManagedDevices");
            }

            if (this.HasParameter("managedDeviceId"))
            {
                request.RequestBody.ManagedDeviceId = this.GetParameter<string>("managedDeviceId");
            }

            return request;
        }
    }
}
