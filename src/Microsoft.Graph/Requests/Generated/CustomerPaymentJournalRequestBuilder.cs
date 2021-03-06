// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CustomerPaymentJournalRequestBuilder.
    /// </summary>
    public partial class CustomerPaymentJournalRequestBuilder : EntityRequestBuilder, ICustomerPaymentJournalRequestBuilder
    {

        /// <summary>
        /// Constructs a new CustomerPaymentJournalRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CustomerPaymentJournalRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICustomerPaymentJournalRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICustomerPaymentJournalRequest Request(IEnumerable<Option> options)
        {
            return new CustomerPaymentJournalRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CustomerPayments.
        /// </summary>
        /// <returns>The <see cref="ICustomerPaymentJournalCustomerPaymentsCollectionRequestBuilder"/>.</returns>
        public ICustomerPaymentJournalCustomerPaymentsCollectionRequestBuilder CustomerPayments
        {
            get
            {
                return new CustomerPaymentJournalCustomerPaymentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("customerPayments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Account.
        /// </summary>
        /// <returns>The <see cref="IAccountRequestBuilder"/>.</returns>
        public IAccountRequestBuilder Account
        {
            get
            {
                return new AccountRequestBuilder(this.AppendSegmentToRequestUrl("account"), this.Client);
            }
        }
    
    }
}
