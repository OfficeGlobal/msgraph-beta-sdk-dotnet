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
    /// The interface IOnenoteOperationRequest.
    /// </summary>
    public partial interface IOnenoteOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteOperation using PUT.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <returns>The created OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> CreateAsync(OnenoteOperation onenoteOperationToCreate);        /// <summary>
        /// Creates the specified OnenoteOperation using PUT.
        /// </summary>
        /// <param name="onenoteOperationToCreate">The OnenoteOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> CreateAsync(OnenoteOperation onenoteOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnenoteOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnenoteOperation.
        /// </summary>
        /// <returns>The OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> GetAsync();

        /// <summary>
        /// Gets the specified OnenoteOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteOperation using PATCH.
        /// </summary>
        /// <param name="onenoteOperationToUpdate">The OnenoteOperation to update.</param>
        /// <returns>The updated OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> UpdateAsync(OnenoteOperation onenoteOperationToUpdate);

        /// <summary>
        /// Updates the specified OnenoteOperation using PATCH.
        /// </summary>
        /// <param name="onenoteOperationToUpdate">The OnenoteOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OnenoteOperation.</returns>
        System.Threading.Tasks.Task<OnenoteOperation> UpdateAsync(OnenoteOperation onenoteOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteOperationRequest Expand(Expression<Func<OnenoteOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteOperationRequest Select(Expression<Func<OnenoteOperation, object>> selectExpression);

    }
}
