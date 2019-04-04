// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IBookingAppointmentRequest.
    /// </summary>
    public partial interface IBookingAppointmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingAppointment using PUT.
        /// </summary>
        /// <param name="bookingAppointmentToCreate">The BookingAppointment to create.</param>
        /// <returns>The created BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> CreateAsync(BookingAppointment bookingAppointmentToCreate);        /// <summary>
        /// Creates the specified BookingAppointment using PUT.
        /// </summary>
        /// <param name="bookingAppointmentToCreate">The BookingAppointment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> CreateAsync(BookingAppointment bookingAppointmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BookingAppointment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BookingAppointment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingAppointment.
        /// </summary>
        /// <returns>The BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> GetAsync();

        /// <summary>
        /// Gets the specified BookingAppointment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingAppointment using PATCH.
        /// </summary>
        /// <param name="bookingAppointmentToUpdate">The BookingAppointment to update.</param>
        /// <returns>The updated BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> UpdateAsync(BookingAppointment bookingAppointmentToUpdate);

        /// <summary>
        /// Updates the specified BookingAppointment using PATCH.
        /// </summary>
        /// <param name="bookingAppointmentToUpdate">The BookingAppointment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated BookingAppointment.</returns>
        System.Threading.Tasks.Task<BookingAppointment> UpdateAsync(BookingAppointment bookingAppointmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingAppointmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingAppointmentRequest Expand(Expression<Func<BookingAppointment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingAppointmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingAppointmentRequest Select(Expression<Func<BookingAppointment, object>> selectExpression);

    }
}
