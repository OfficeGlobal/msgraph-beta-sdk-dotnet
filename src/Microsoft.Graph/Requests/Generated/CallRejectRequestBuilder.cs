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
    /// The type CallRejectRequestBuilder.
    /// </summary>
    public partial class CallRejectRequestBuilder : BaseActionMethodRequestBuilder<ICallRejectRequest>, ICallRejectRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="CallRejectRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="reason">A reason parameter for the OData method call.</param>
        public CallRejectRequestBuilder(
            string requestUrl,
            IBaseClient client,
            RejectReason? reason)
            : base(requestUrl, client)
        {
            this.SetParameter("reason", reason, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ICallRejectRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new CallRejectRequest(functionUrl, this.Client, options);

            if (this.HasParameter("reason"))
            {
                request.RequestBody.Reason = this.GetParameter<RejectReason?>("reason");
            }

            return request;
        }
    }
}
