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
    /// The type BookingBusinessRequestBuilder.
    /// </summary>
    public partial class BookingBusinessRequestBuilder : BookingNamedEntityRequestBuilder, IBookingBusinessRequestBuilder
    {

        /// <summary>
        /// Constructs a new BookingBusinessRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BookingBusinessRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IBookingBusinessRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IBookingBusinessRequest Request(IEnumerable<Option> options)
        {
            return new BookingBusinessRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Appointments.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessAppointmentsCollectionRequestBuilder"/>.</returns>
        public IBookingBusinessAppointmentsCollectionRequestBuilder Appointments
        {
            get
            {
                return new BookingBusinessAppointmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("appointments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessCalendarViewCollectionRequestBuilder"/>.</returns>
        public IBookingBusinessCalendarViewCollectionRequestBuilder CalendarView
        {
            get
            {
                return new BookingBusinessCalendarViewCollectionRequestBuilder(this.AppendSegmentToRequestUrl("calendarView"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Customers.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessCustomersCollectionRequestBuilder"/>.</returns>
        public IBookingBusinessCustomersCollectionRequestBuilder Customers
        {
            get
            {
                return new BookingBusinessCustomersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("customers"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Services.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessServicesCollectionRequestBuilder"/>.</returns>
        public IBookingBusinessServicesCollectionRequestBuilder Services
        {
            get
            {
                return new BookingBusinessServicesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("services"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for StaffMembers.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessStaffMembersCollectionRequestBuilder"/>.</returns>
        public IBookingBusinessStaffMembersCollectionRequestBuilder StaffMembers
        {
            get
            {
                return new BookingBusinessStaffMembersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("staffMembers"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for BookingBusinessPublish.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessPublishRequestBuilder"/>.</returns>
        public IBookingBusinessPublishRequestBuilder Publish()
        {
            return new BookingBusinessPublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.publish"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for BookingBusinessUnpublish.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessUnpublishRequestBuilder"/>.</returns>
        public IBookingBusinessUnpublishRequestBuilder Unpublish()
        {
            return new BookingBusinessUnpublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unpublish"),
                this.Client);
        }
    
    }
}
