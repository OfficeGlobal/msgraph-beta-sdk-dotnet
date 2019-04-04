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
    /// The type BookingBusinessCustomersCollectionRequestBuilder.
    /// </summary>
    public partial class BookingBusinessCustomersCollectionRequestBuilder : BaseRequestBuilder, IBookingBusinessCustomersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new BookingBusinessCustomersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BookingBusinessCustomersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IBookingBusinessCustomersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IBookingBusinessCustomersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new BookingBusinessCustomersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBookingCustomerRequestBuilder"/> for the specified BookingBusinessBookingCustomer.
        /// </summary>
        /// <param name="id">The ID for the BookingBusinessBookingCustomer.</param>
        /// <returns>The <see cref="IBookingCustomerRequestBuilder"/>.</returns>
        public IBookingCustomerRequestBuilder this[string id]
        {
            get
            {
                return new BookingCustomerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
