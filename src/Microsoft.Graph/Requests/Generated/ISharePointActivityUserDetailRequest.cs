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
    /// The interface ISharePointActivityUserDetailRequest.
    /// </summary>
    public partial interface ISharePointActivityUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePointActivityUserDetail using PUT.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToCreate">The SharePointActivityUserDetail to create.</param>
        /// <returns>The created SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> CreateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToCreate);        /// <summary>
        /// Creates the specified SharePointActivityUserDetail using PUT.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToCreate">The SharePointActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> CreateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharePointActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharePointActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharePointActivityUserDetail.
        /// </summary>
        /// <returns>The SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified SharePointActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail to update.</param>
        /// <returns>The updated SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> UpdateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate);

        /// <summary>
        /// Updates the specified SharePointActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserDetailToUpdate">The SharePointActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharePointActivityUserDetail.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserDetail> UpdateAsync(SharePointActivityUserDetail sharePointActivityUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserDetailRequest Expand(Expression<Func<SharePointActivityUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserDetailRequest Select(Expression<Func<SharePointActivityUserDetail, object>> selectExpression);

    }
}
