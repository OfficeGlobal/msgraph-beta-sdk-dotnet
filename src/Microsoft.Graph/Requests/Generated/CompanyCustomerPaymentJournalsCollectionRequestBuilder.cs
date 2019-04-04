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
    /// The type CompanyCustomerPaymentJournalsCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyCustomerPaymentJournalsCollectionRequestBuilder : BaseRequestBuilder, ICompanyCustomerPaymentJournalsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyCustomerPaymentJournalsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyCustomerPaymentJournalsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyCustomerPaymentJournalsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyCustomerPaymentJournalsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyCustomerPaymentJournalsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICustomerPaymentJournalRequestBuilder"/> for the specified CompanyCustomerPaymentJournal.
        /// </summary>
        /// <param name="id">The ID for the CompanyCustomerPaymentJournal.</param>
        /// <returns>The <see cref="ICustomerPaymentJournalRequestBuilder"/>.</returns>
        public ICustomerPaymentJournalRequestBuilder this[string id]
        {
            get
            {
                return new CustomerPaymentJournalRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
