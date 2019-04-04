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
    /// The interface ITaxAreaRequest.
    /// </summary>
    public partial interface ITaxAreaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TaxArea using PUT.
        /// </summary>
        /// <param name="taxAreaToCreate">The TaxArea to create.</param>
        /// <returns>The created TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> CreateAsync(TaxArea taxAreaToCreate);        /// <summary>
        /// Creates the specified TaxArea using PUT.
        /// </summary>
        /// <param name="taxAreaToCreate">The TaxArea to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> CreateAsync(TaxArea taxAreaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TaxArea.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TaxArea.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TaxArea.
        /// </summary>
        /// <returns>The TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> GetAsync();

        /// <summary>
        /// Gets the specified TaxArea.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TaxArea using PATCH.
        /// </summary>
        /// <param name="taxAreaToUpdate">The TaxArea to update.</param>
        /// <returns>The updated TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> UpdateAsync(TaxArea taxAreaToUpdate);

        /// <summary>
        /// Updates the specified TaxArea using PATCH.
        /// </summary>
        /// <param name="taxAreaToUpdate">The TaxArea to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TaxArea.</returns>
        System.Threading.Tasks.Task<TaxArea> UpdateAsync(TaxArea taxAreaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaxAreaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaxAreaRequest Expand(Expression<Func<TaxArea, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITaxAreaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITaxAreaRequest Select(Expression<Func<TaxArea, object>> selectExpression);

    }
}