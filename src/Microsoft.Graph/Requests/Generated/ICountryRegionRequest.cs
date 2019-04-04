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
    /// The interface ICountryRegionRequest.
    /// </summary>
    public partial interface ICountryRegionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CountryRegion using PUT.
        /// </summary>
        /// <param name="countryRegionToCreate">The CountryRegion to create.</param>
        /// <returns>The created CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> CreateAsync(CountryRegion countryRegionToCreate);        /// <summary>
        /// Creates the specified CountryRegion using PUT.
        /// </summary>
        /// <param name="countryRegionToCreate">The CountryRegion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> CreateAsync(CountryRegion countryRegionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CountryRegion.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CountryRegion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CountryRegion.
        /// </summary>
        /// <returns>The CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> GetAsync();

        /// <summary>
        /// Gets the specified CountryRegion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CountryRegion using PATCH.
        /// </summary>
        /// <param name="countryRegionToUpdate">The CountryRegion to update.</param>
        /// <returns>The updated CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> UpdateAsync(CountryRegion countryRegionToUpdate);

        /// <summary>
        /// Updates the specified CountryRegion using PATCH.
        /// </summary>
        /// <param name="countryRegionToUpdate">The CountryRegion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> UpdateAsync(CountryRegion countryRegionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Expand(Expression<Func<CountryRegion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Select(Expression<Func<CountryRegion, object>> selectExpression);

    }
}
