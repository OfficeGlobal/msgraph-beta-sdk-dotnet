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
    /// The interface IRoleScopeTagRequest.
    /// </summary>
    public partial interface IRoleScopeTagRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RoleScopeTag using PUT.
        /// </summary>
        /// <param name="roleScopeTagToCreate">The RoleScopeTag to create.</param>
        /// <returns>The created RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> CreateAsync(RoleScopeTag roleScopeTagToCreate);        /// <summary>
        /// Creates the specified RoleScopeTag using PUT.
        /// </summary>
        /// <param name="roleScopeTagToCreate">The RoleScopeTag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> CreateAsync(RoleScopeTag roleScopeTagToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RoleScopeTag.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RoleScopeTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RoleScopeTag.
        /// </summary>
        /// <returns>The RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> GetAsync();

        /// <summary>
        /// Gets the specified RoleScopeTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RoleScopeTag using PATCH.
        /// </summary>
        /// <param name="roleScopeTagToUpdate">The RoleScopeTag to update.</param>
        /// <returns>The updated RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> UpdateAsync(RoleScopeTag roleScopeTagToUpdate);

        /// <summary>
        /// Updates the specified RoleScopeTag using PATCH.
        /// </summary>
        /// <param name="roleScopeTagToUpdate">The RoleScopeTag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated RoleScopeTag.</returns>
        System.Threading.Tasks.Task<RoleScopeTag> UpdateAsync(RoleScopeTag roleScopeTagToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleScopeTagRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleScopeTagRequest Expand(Expression<Func<RoleScopeTag, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleScopeTagRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleScopeTagRequest Select(Expression<Func<RoleScopeTag, object>> selectExpression);

    }
}
