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
    /// The interface ICircularGeofenceManagementConditionRequest.
    /// </summary>
    public partial interface ICircularGeofenceManagementConditionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CircularGeofenceManagementCondition using PUT.
        /// </summary>
        /// <param name="circularGeofenceManagementConditionToCreate">The CircularGeofenceManagementCondition to create.</param>
        /// <returns>The created CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> CreateAsync(CircularGeofenceManagementCondition circularGeofenceManagementConditionToCreate);        /// <summary>
        /// Creates the specified CircularGeofenceManagementCondition using PUT.
        /// </summary>
        /// <param name="circularGeofenceManagementConditionToCreate">The CircularGeofenceManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> CreateAsync(CircularGeofenceManagementCondition circularGeofenceManagementConditionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CircularGeofenceManagementCondition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CircularGeofenceManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CircularGeofenceManagementCondition.
        /// </summary>
        /// <returns>The CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> GetAsync();

        /// <summary>
        /// Gets the specified CircularGeofenceManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CircularGeofenceManagementCondition using PATCH.
        /// </summary>
        /// <param name="circularGeofenceManagementConditionToUpdate">The CircularGeofenceManagementCondition to update.</param>
        /// <returns>The updated CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> UpdateAsync(CircularGeofenceManagementCondition circularGeofenceManagementConditionToUpdate);

        /// <summary>
        /// Updates the specified CircularGeofenceManagementCondition using PATCH.
        /// </summary>
        /// <param name="circularGeofenceManagementConditionToUpdate">The CircularGeofenceManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated CircularGeofenceManagementCondition.</returns>
        System.Threading.Tasks.Task<CircularGeofenceManagementCondition> UpdateAsync(CircularGeofenceManagementCondition circularGeofenceManagementConditionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICircularGeofenceManagementConditionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICircularGeofenceManagementConditionRequest Expand(Expression<Func<CircularGeofenceManagementCondition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICircularGeofenceManagementConditionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICircularGeofenceManagementConditionRequest Select(Expression<Func<CircularGeofenceManagementCondition, object>> selectExpression);

    }
}
