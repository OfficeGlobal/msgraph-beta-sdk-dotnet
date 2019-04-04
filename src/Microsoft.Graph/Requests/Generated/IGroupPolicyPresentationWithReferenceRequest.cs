// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGroupPolicyPresentationWithReferenceRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified GroupPolicyPresentation.
        /// </summary>
        /// <returns>The GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified GroupPolicyPresentation using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationToCreate">The GroupPolicyPresentation to create.</param>
        /// <returns>The created GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> CreateAsync(GroupPolicyPresentation groupPolicyPresentationToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentation using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationToCreate">The GroupPolicyPresentation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> CreateAsync(GroupPolicyPresentation groupPolicyPresentationToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified GroupPolicyPresentation using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationToUpdate">The GroupPolicyPresentation to update.</param>
        /// <returns>The updated GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> UpdateAsync(GroupPolicyPresentation groupPolicyPresentationToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentation using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationToUpdate">The GroupPolicyPresentation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentation.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentation> UpdateAsync(GroupPolicyPresentation groupPolicyPresentationToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified GroupPolicyPresentation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationWithReferenceRequest Expand(Expression<Func<GroupPolicyPresentation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationWithReferenceRequest Select(Expression<Func<GroupPolicyPresentation, object>> selectExpression);

    }
}
