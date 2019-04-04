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
    /// The interface IScheduleRequest.
    /// </summary>
    public partial interface IScheduleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Schedule using PUT.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <returns>The created Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> CreateAsync(Schedule scheduleToCreate);        /// <summary>
        /// Creates the specified Schedule using PUT.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> CreateAsync(Schedule scheduleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Schedule.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Schedule.
        /// </summary>
        /// <returns>The Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> GetAsync();

        /// <summary>
        /// Gets the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Schedule using PATCH.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <returns>The updated Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> UpdateAsync(Schedule scheduleToUpdate);

        /// <summary>
        /// Updates the specified Schedule using PATCH.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Schedule.</returns>
        System.Threading.Tasks.Task<Schedule> UpdateAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IScheduleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IScheduleRequest Expand(Expression<Func<Schedule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IScheduleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IScheduleRequest Select(Expression<Func<Schedule, object>> selectExpression);

    }
}
