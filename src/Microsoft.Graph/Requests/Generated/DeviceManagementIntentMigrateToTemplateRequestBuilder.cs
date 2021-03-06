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
    /// The type DeviceManagementIntentMigrateToTemplateRequestBuilder.
    /// </summary>
    public partial class DeviceManagementIntentMigrateToTemplateRequestBuilder : BaseActionMethodRequestBuilder<IDeviceManagementIntentMigrateToTemplateRequest>, IDeviceManagementIntentMigrateToTemplateRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementIntentMigrateToTemplateRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="preserveCustomValues">A preserveCustomValues parameter for the OData method call.</param>
        /// <param name="newTemplateId">A newTemplateId parameter for the OData method call.</param>
        public DeviceManagementIntentMigrateToTemplateRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool preserveCustomValues,
            string newTemplateId)
            : base(requestUrl, client)
        {
            this.SetParameter("preserveCustomValues", preserveCustomValues, false);
            this.SetParameter("newTemplateId", newTemplateId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementIntentMigrateToTemplateRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementIntentMigrateToTemplateRequest(functionUrl, this.Client, options);

            if (this.HasParameter("preserveCustomValues"))
            {
                request.RequestBody.PreserveCustomValues = this.GetParameter<bool>("preserveCustomValues");
            }

            if (this.HasParameter("newTemplateId"))
            {
                request.RequestBody.NewTemplateId = this.GetParameter<string>("newTemplateId");
            }

            return request;
        }
    }
}
