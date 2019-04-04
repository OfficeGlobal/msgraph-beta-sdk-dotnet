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
    /// The interface IEntityRequest.
    /// </summary>
    public partial interface IEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Entity using PUT.
        /// </summary>
        /// <param name="entityToCreate">The Entity to create.</param>
        /// <returns>The created Entity.</returns>
        System.Threading.Tasks.Task<Entity> CreateAsync(Entity entityToCreate);        /// <summary>
        /// Creates the specified Entity using PUT.
        /// </summary>
        /// <param name="entityToCreate">The Entity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Entity.</returns>
        System.Threading.Tasks.Task<Entity> CreateAsync(Entity entityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Entity.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Entity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Entity.
        /// </summary>
        /// <returns>The Entity.</returns>
        System.Threading.Tasks.Task<Entity> GetAsync();

        /// <summary>
        /// Gets the specified Entity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Entity.</returns>
        System.Threading.Tasks.Task<Entity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Entity using PATCH.
        /// </summary>
        /// <param name="entityToUpdate">The Entity to update.</param>
        /// <returns>The updated Entity.</returns>
        System.Threading.Tasks.Task<Entity> UpdateAsync(Entity entityToUpdate);

        /// <summary>
        /// Updates the specified Entity using PATCH.
        /// </summary>
        /// <param name="entityToUpdate">The Entity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Entity.</returns>
        System.Threading.Tasks.Task<Entity> UpdateAsync(Entity entityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Expand(Expression<Func<Entity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Select(Expression<Func<Entity, object>> selectExpression);

    }
}
