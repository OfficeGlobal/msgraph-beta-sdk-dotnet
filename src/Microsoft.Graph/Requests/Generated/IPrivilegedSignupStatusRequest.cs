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
    /// The interface IPrivilegedSignupStatusRequest.
    /// </summary>
    public partial interface IPrivilegedSignupStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivilegedSignupStatus using PUT.
        /// </summary>
        /// <param name="privilegedSignupStatusToCreate">The PrivilegedSignupStatus to create.</param>
        /// <returns>The created PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> CreateAsync(PrivilegedSignupStatus privilegedSignupStatusToCreate);        /// <summary>
        /// Creates the specified PrivilegedSignupStatus using PUT.
        /// </summary>
        /// <param name="privilegedSignupStatusToCreate">The PrivilegedSignupStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> CreateAsync(PrivilegedSignupStatus privilegedSignupStatusToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrivilegedSignupStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivilegedSignupStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrivilegedSignupStatus.
        /// </summary>
        /// <returns>The PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedSignupStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrivilegedSignupStatus using PATCH.
        /// </summary>
        /// <param name="privilegedSignupStatusToUpdate">The PrivilegedSignupStatus to update.</param>
        /// <returns>The updated PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> UpdateAsync(PrivilegedSignupStatus privilegedSignupStatusToUpdate);

        /// <summary>
        /// Updates the specified PrivilegedSignupStatus using PATCH.
        /// </summary>
        /// <param name="privilegedSignupStatusToUpdate">The PrivilegedSignupStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PrivilegedSignupStatus.</returns>
        System.Threading.Tasks.Task<PrivilegedSignupStatus> UpdateAsync(PrivilegedSignupStatus privilegedSignupStatusToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedSignupStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedSignupStatusRequest Expand(Expression<Func<PrivilegedSignupStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedSignupStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedSignupStatusRequest Select(Expression<Func<PrivilegedSignupStatus, object>> selectExpression);

    }
}
