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
    /// The interface IPlannerRequest.
    /// </summary>
    public partial interface IPlannerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Planner using POST.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <returns>The created Planner.</returns>
        System.Threading.Tasks.Task<Planner> CreateAsync(Planner plannerToCreate);        /// <summary>
        /// Creates the specified Planner using POST.
        /// </summary>
        /// <param name="plannerToCreate">The Planner to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Planner.</returns>
        System.Threading.Tasks.Task<Planner> CreateAsync(Planner plannerToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Planner.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Planner.
        /// </summary>
        /// <returns>The Planner.</returns>
        System.Threading.Tasks.Task<Planner> GetAsync();

        /// <summary>
        /// Gets the specified Planner.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Planner.</returns>
        System.Threading.Tasks.Task<Planner> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Planner using PATCH.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <returns>The updated Planner.</returns>
        System.Threading.Tasks.Task<Planner> UpdateAsync(Planner plannerToUpdate);

        /// <summary>
        /// Updates the specified Planner using PATCH.
        /// </summary>
        /// <param name="plannerToUpdate">The Planner to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Planner.</returns>
        System.Threading.Tasks.Task<Planner> UpdateAsync(Planner plannerToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Expand(Expression<Func<Planner, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRequest Select(Expression<Func<Planner, object>> selectExpression);

    }
}
