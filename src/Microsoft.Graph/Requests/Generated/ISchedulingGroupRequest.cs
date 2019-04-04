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
    /// The interface ISchedulingGroupRequest.
    /// </summary>
    public partial interface ISchedulingGroupRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SchedulingGroup using PUT.
        /// </summary>
        /// <param name="schedulingGroupToCreate">The SchedulingGroup to create.</param>
        /// <returns>The created SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> CreateAsync(SchedulingGroup schedulingGroupToCreate);        /// <summary>
        /// Creates the specified SchedulingGroup using PUT.
        /// </summary>
        /// <param name="schedulingGroupToCreate">The SchedulingGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> CreateAsync(SchedulingGroup schedulingGroupToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SchedulingGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SchedulingGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SchedulingGroup.
        /// </summary>
        /// <returns>The SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> GetAsync();

        /// <summary>
        /// Gets the specified SchedulingGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SchedulingGroup using PATCH.
        /// </summary>
        /// <param name="schedulingGroupToUpdate">The SchedulingGroup to update.</param>
        /// <returns>The updated SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> UpdateAsync(SchedulingGroup schedulingGroupToUpdate);

        /// <summary>
        /// Updates the specified SchedulingGroup using PATCH.
        /// </summary>
        /// <param name="schedulingGroupToUpdate">The SchedulingGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SchedulingGroup.</returns>
        System.Threading.Tasks.Task<SchedulingGroup> UpdateAsync(SchedulingGroup schedulingGroupToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISchedulingGroupRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISchedulingGroupRequest Expand(Expression<Func<SchedulingGroup, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISchedulingGroupRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISchedulingGroupRequest Select(Expression<Func<SchedulingGroup, object>> selectExpression);

    }
}
