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
    /// The interface ITeamsDeviceUsageDistributionUserCountsRequest.
    /// </summary>
    public partial interface ITeamsDeviceUsageDistributionUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsDeviceUsageDistributionUserCounts using PUT.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToCreate">The TeamsDeviceUsageDistributionUserCounts to create.</param>
        /// <returns>The created TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> CreateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToCreate);        /// <summary>
        /// Creates the specified TeamsDeviceUsageDistributionUserCounts using PUT.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToCreate">The TeamsDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> CreateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TeamsDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToUpdate">The TeamsDeviceUsageDistributionUserCounts to update.</param>
        /// <returns>The updated TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> UpdateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToUpdate);

        /// <summary>
        /// Updates the specified TeamsDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToUpdate">The TeamsDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> UpdateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Expand(Expression<Func<TeamsDeviceUsageDistributionUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Select(Expression<Func<TeamsDeviceUsageDistributionUserCounts, object>> selectExpression);

    }
}
