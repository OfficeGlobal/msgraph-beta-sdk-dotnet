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
    /// The interface IFilterOperatorSchemaRequest.
    /// </summary>
    public partial interface IFilterOperatorSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FilterOperatorSchema using PUT.
        /// </summary>
        /// <param name="filterOperatorSchemaToCreate">The FilterOperatorSchema to create.</param>
        /// <returns>The created FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> CreateAsync(FilterOperatorSchema filterOperatorSchemaToCreate);        /// <summary>
        /// Creates the specified FilterOperatorSchema using PUT.
        /// </summary>
        /// <param name="filterOperatorSchemaToCreate">The FilterOperatorSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> CreateAsync(FilterOperatorSchema filterOperatorSchemaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified FilterOperatorSchema.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified FilterOperatorSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified FilterOperatorSchema.
        /// </summary>
        /// <returns>The FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> GetAsync();

        /// <summary>
        /// Gets the specified FilterOperatorSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PATCH.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema to update.</param>
        /// <returns>The updated FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> UpdateAsync(FilterOperatorSchema filterOperatorSchemaToUpdate);

        /// <summary>
        /// Updates the specified FilterOperatorSchema using PATCH.
        /// </summary>
        /// <param name="filterOperatorSchemaToUpdate">The FilterOperatorSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated FilterOperatorSchema.</returns>
        System.Threading.Tasks.Task<FilterOperatorSchema> UpdateAsync(FilterOperatorSchema filterOperatorSchemaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Expand(Expression<Func<FilterOperatorSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFilterOperatorSchemaRequest Select(Expression<Func<FilterOperatorSchema, object>> selectExpression);

    }
}
