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
    /// The interface ITeamsUserActivityUserCountsRequest.
    /// </summary>
    public partial interface ITeamsUserActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using PUT.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <returns>The created TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> CreateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate);        /// <summary>
        /// Creates the specified TeamsUserActivityUserCounts using PUT.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToCreate">The TeamsUserActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> CreateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <returns>The TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified TeamsUserActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <returns>The updated TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> UpdateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate);

        /// <summary>
        /// Updates the specified TeamsUserActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityUserCountsToUpdate">The TeamsUserActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TeamsUserActivityUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityUserCounts> UpdateAsync(TeamsUserActivityUserCounts teamsUserActivityUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserCountsRequest Expand(Expression<Func<TeamsUserActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityUserCountsRequest Select(Expression<Func<TeamsUserActivityUserCounts, object>> selectExpression);

    }
}
