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
    /// The interface ITiIndicatorRequest.
    /// </summary>
    public partial interface ITiIndicatorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TiIndicator using PUT.
        /// </summary>
        /// <param name="tiIndicatorToCreate">The TiIndicator to create.</param>
        /// <returns>The created TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> CreateAsync(TiIndicator tiIndicatorToCreate);        /// <summary>
        /// Creates the specified TiIndicator using PUT.
        /// </summary>
        /// <param name="tiIndicatorToCreate">The TiIndicator to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> CreateAsync(TiIndicator tiIndicatorToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TiIndicator.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TiIndicator.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TiIndicator.
        /// </summary>
        /// <returns>The TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> GetAsync();

        /// <summary>
        /// Gets the specified TiIndicator.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TiIndicator using PATCH.
        /// </summary>
        /// <param name="tiIndicatorToUpdate">The TiIndicator to update.</param>
        /// <returns>The updated TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> UpdateAsync(TiIndicator tiIndicatorToUpdate);

        /// <summary>
        /// Updates the specified TiIndicator using PATCH.
        /// </summary>
        /// <param name="tiIndicatorToUpdate">The TiIndicator to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TiIndicator.</returns>
        System.Threading.Tasks.Task<TiIndicator> UpdateAsync(TiIndicator tiIndicatorToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITiIndicatorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITiIndicatorRequest Expand(Expression<Func<TiIndicator, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITiIndicatorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITiIndicatorRequest Select(Expression<Func<TiIndicator, object>> selectExpression);

    }
}
