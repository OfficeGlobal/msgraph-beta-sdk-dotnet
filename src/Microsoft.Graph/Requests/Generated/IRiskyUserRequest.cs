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
    /// The interface IRiskyUserRequest.
    /// </summary>
    public partial interface IRiskyUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RiskyUser using PUT.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <returns>The created RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> CreateAsync(RiskyUser riskyUserToCreate);        /// <summary>
        /// Creates the specified RiskyUser using PUT.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> CreateAsync(RiskyUser riskyUserToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RiskyUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RiskyUser.
        /// </summary>
        /// <returns>The RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> GetAsync();

        /// <summary>
        /// Gets the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RiskyUser using PATCH.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <returns>The updated RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> UpdateAsync(RiskyUser riskyUserToUpdate);

        /// <summary>
        /// Updates the specified RiskyUser using PATCH.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> UpdateAsync(RiskyUser riskyUserToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Expand(Expression<Func<RiskyUser, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Select(Expression<Func<RiskyUser, object>> selectExpression);

    }
}
