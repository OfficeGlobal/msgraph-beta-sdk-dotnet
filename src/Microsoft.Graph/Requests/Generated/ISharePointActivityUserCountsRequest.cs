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
    /// The interface ISharePointActivityUserCountsRequest.
    /// </summary>
    public partial interface ISharePointActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePointActivityUserCounts using PUT.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToCreate">The SharePointActivityUserCounts to create.</param>
        /// <returns>The created SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> CreateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToCreate);        /// <summary>
        /// Creates the specified SharePointActivityUserCounts using PUT.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToCreate">The SharePointActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> CreateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharePointActivityUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharePointActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharePointActivityUserCounts.
        /// </summary>
        /// <returns>The SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified SharePointActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharePointActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToUpdate">The SharePointActivityUserCounts to update.</param>
        /// <returns>The updated SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> UpdateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToUpdate);

        /// <summary>
        /// Updates the specified SharePointActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToUpdate">The SharePointActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> UpdateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Expand(Expression<Func<SharePointActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Select(Expression<Func<SharePointActivityUserCounts, object>> selectExpression);

    }
}
