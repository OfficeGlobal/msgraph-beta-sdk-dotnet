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
    /// The type WorkbookFunctionsImPowerRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsImPowerRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsImPowerRequest>, IWorkbookFunctionsImPowerRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsImPowerRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="inumber">A inumber parameter for the OData method call.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        public WorkbookFunctionsImPowerRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken inumber,
            Newtonsoft.Json.Linq.JToken number)
            : base(requestUrl, client)
        {
            this.SetParameter("inumber", inumber, true);
            this.SetParameter("number", number, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsImPowerRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsImPowerRequest(functionUrl, this.Client, options);

            if (this.HasParameter("inumber"))
            {
                request.RequestBody.Inumber = this.GetParameter<Newtonsoft.Json.Linq.JToken>("inumber");
            }

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<Newtonsoft.Json.Linq.JToken>("number");
            }

            return request;
        }
    }
}
