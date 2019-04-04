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
    /// The interface IPlannerDeltaRequest.
    /// </summary>
    public partial interface IPlannerDeltaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerDelta using PUT.
        /// </summary>
        /// <param name="plannerDeltaToCreate">The PlannerDelta to create.</param>
        /// <returns>The created PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> CreateAsync(PlannerDelta plannerDeltaToCreate);        /// <summary>
        /// Creates the specified PlannerDelta using PUT.
        /// </summary>
        /// <param name="plannerDeltaToCreate">The PlannerDelta to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> CreateAsync(PlannerDelta plannerDeltaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerDelta.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerDelta.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerDelta.
        /// </summary>
        /// <returns>The PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> GetAsync();

        /// <summary>
        /// Gets the specified PlannerDelta.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerDelta using PATCH.
        /// </summary>
        /// <param name="plannerDeltaToUpdate">The PlannerDelta to update.</param>
        /// <returns>The updated PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> UpdateAsync(PlannerDelta plannerDeltaToUpdate);

        /// <summary>
        /// Updates the specified PlannerDelta using PATCH.
        /// </summary>
        /// <param name="plannerDeltaToUpdate">The PlannerDelta to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PlannerDelta.</returns>
        System.Threading.Tasks.Task<PlannerDelta> UpdateAsync(PlannerDelta plannerDeltaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerDeltaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerDeltaRequest Expand(Expression<Func<PlannerDelta, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerDeltaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerDeltaRequest Select(Expression<Func<PlannerDelta, object>> selectExpression);

    }
}
