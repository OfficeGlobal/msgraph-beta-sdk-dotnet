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
    /// The interface IPrivilegedRoleAssignmentRequestRequest.
    /// </summary>
    public partial interface IPrivilegedRoleAssignmentRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivilegedRoleAssignmentRequestObject using PUT.
        /// </summary>
        /// <param name="privilegedRoleAssignmentRequestObjectToCreate">The PrivilegedRoleAssignmentRequestObject to create.</param>
        /// <returns>The created PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> CreateAsync(PrivilegedRoleAssignmentRequestObject privilegedRoleAssignmentRequestObjectToCreate);        /// <summary>
        /// Creates the specified PrivilegedRoleAssignmentRequestObject using PUT.
        /// </summary>
        /// <param name="privilegedRoleAssignmentRequestObjectToCreate">The PrivilegedRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> CreateAsync(PrivilegedRoleAssignmentRequestObject privilegedRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrivilegedRoleAssignmentRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivilegedRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrivilegedRoleAssignmentRequestObject.
        /// </summary>
        /// <returns>The PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrivilegedRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentRequestObjectToUpdate">The PrivilegedRoleAssignmentRequestObject to update.</param>
        /// <returns>The updated PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> UpdateAsync(PrivilegedRoleAssignmentRequestObject privilegedRoleAssignmentRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified PrivilegedRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentRequestObjectToUpdate">The PrivilegedRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PrivilegedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignmentRequestObject> UpdateAsync(PrivilegedRoleAssignmentRequestObject privilegedRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentRequestRequest Expand(Expression<Func<PrivilegedRoleAssignmentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentRequestRequest Select(Expression<Func<PrivilegedRoleAssignmentRequestObject, object>> selectExpression);

    }
}
