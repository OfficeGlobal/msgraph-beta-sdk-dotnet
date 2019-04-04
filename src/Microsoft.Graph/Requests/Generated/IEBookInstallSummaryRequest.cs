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
    /// The interface IEBookInstallSummaryRequest.
    /// </summary>
    public partial interface IEBookInstallSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EBookInstallSummary using PUT.
        /// </summary>
        /// <param name="eBookInstallSummaryToCreate">The EBookInstallSummary to create.</param>
        /// <returns>The created EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> CreateAsync(EBookInstallSummary eBookInstallSummaryToCreate);        /// <summary>
        /// Creates the specified EBookInstallSummary using PUT.
        /// </summary>
        /// <param name="eBookInstallSummaryToCreate">The EBookInstallSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> CreateAsync(EBookInstallSummary eBookInstallSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EBookInstallSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EBookInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EBookInstallSummary.
        /// </summary>
        /// <returns>The EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> GetAsync();

        /// <summary>
        /// Gets the specified EBookInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EBookInstallSummary using PATCH.
        /// </summary>
        /// <param name="eBookInstallSummaryToUpdate">The EBookInstallSummary to update.</param>
        /// <returns>The updated EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> UpdateAsync(EBookInstallSummary eBookInstallSummaryToUpdate);

        /// <summary>
        /// Updates the specified EBookInstallSummary using PATCH.
        /// </summary>
        /// <param name="eBookInstallSummaryToUpdate">The EBookInstallSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EBookInstallSummary.</returns>
        System.Threading.Tasks.Task<EBookInstallSummary> UpdateAsync(EBookInstallSummary eBookInstallSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEBookInstallSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEBookInstallSummaryRequest Expand(Expression<Func<EBookInstallSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEBookInstallSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEBookInstallSummaryRequest Select(Expression<Func<EBookInstallSummary, object>> selectExpression);

    }
}
