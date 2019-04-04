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
    /// The interface IRemoteActionAuditRequest.
    /// </summary>
    public partial interface IRemoteActionAuditRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RemoteActionAudit using PUT.
        /// </summary>
        /// <param name="remoteActionAuditToCreate">The RemoteActionAudit to create.</param>
        /// <returns>The created RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> CreateAsync(RemoteActionAudit remoteActionAuditToCreate);        /// <summary>
        /// Creates the specified RemoteActionAudit using PUT.
        /// </summary>
        /// <param name="remoteActionAuditToCreate">The RemoteActionAudit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> CreateAsync(RemoteActionAudit remoteActionAuditToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RemoteActionAudit.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RemoteActionAudit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RemoteActionAudit.
        /// </summary>
        /// <returns>The RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> GetAsync();

        /// <summary>
        /// Gets the specified RemoteActionAudit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RemoteActionAudit using PATCH.
        /// </summary>
        /// <param name="remoteActionAuditToUpdate">The RemoteActionAudit to update.</param>
        /// <returns>The updated RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> UpdateAsync(RemoteActionAudit remoteActionAuditToUpdate);

        /// <summary>
        /// Updates the specified RemoteActionAudit using PATCH.
        /// </summary>
        /// <param name="remoteActionAuditToUpdate">The RemoteActionAudit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated RemoteActionAudit.</returns>
        System.Threading.Tasks.Task<RemoteActionAudit> UpdateAsync(RemoteActionAudit remoteActionAuditToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteActionAuditRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteActionAuditRequest Expand(Expression<Func<RemoteActionAudit, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteActionAuditRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRemoteActionAuditRequest Select(Expression<Func<RemoteActionAudit, object>> selectExpression);

    }
}
