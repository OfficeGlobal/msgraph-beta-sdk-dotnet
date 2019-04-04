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
    /// The interface ICurrencyRequest.
    /// </summary>
    public partial interface ICurrencyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Currency using PUT.
        /// </summary>
        /// <param name="currencyToCreate">The Currency to create.</param>
        /// <returns>The created Currency.</returns>
        System.Threading.Tasks.Task<Currency> CreateAsync(Currency currencyToCreate);        /// <summary>
        /// Creates the specified Currency using PUT.
        /// </summary>
        /// <param name="currencyToCreate">The Currency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Currency.</returns>
        System.Threading.Tasks.Task<Currency> CreateAsync(Currency currencyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Currency.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Currency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Currency.
        /// </summary>
        /// <returns>The Currency.</returns>
        System.Threading.Tasks.Task<Currency> GetAsync();

        /// <summary>
        /// Gets the specified Currency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Currency.</returns>
        System.Threading.Tasks.Task<Currency> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Currency using PATCH.
        /// </summary>
        /// <param name="currencyToUpdate">The Currency to update.</param>
        /// <returns>The updated Currency.</returns>
        System.Threading.Tasks.Task<Currency> UpdateAsync(Currency currencyToUpdate);

        /// <summary>
        /// Updates the specified Currency using PATCH.
        /// </summary>
        /// <param name="currencyToUpdate">The Currency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Currency.</returns>
        System.Threading.Tasks.Task<Currency> UpdateAsync(Currency currencyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Expand(Expression<Func<Currency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Select(Expression<Func<Currency, object>> selectExpression);

    }
}
