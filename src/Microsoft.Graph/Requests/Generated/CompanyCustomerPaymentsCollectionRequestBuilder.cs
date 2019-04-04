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
    /// The type CompanyCustomerPaymentsCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyCustomerPaymentsCollectionRequestBuilder : BaseRequestBuilder, ICompanyCustomerPaymentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyCustomerPaymentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyCustomerPaymentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyCustomerPaymentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyCustomerPaymentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyCustomerPaymentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICustomerPaymentRequestBuilder"/> for the specified CompanyCustomerPayment.
        /// </summary>
        /// <param name="id">The ID for the CompanyCustomerPayment.</param>
        /// <returns>The <see cref="ICustomerPaymentRequestBuilder"/>.</returns>
        public ICustomerPaymentRequestBuilder this[string id]
        {
            get
            {
                return new CustomerPaymentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
