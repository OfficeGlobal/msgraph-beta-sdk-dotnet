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
    /// The interface IGroupPolicyPresentationLongDecimalTextBoxRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationLongDecimalTextBoxRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationLongDecimalTextBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToCreate">The GroupPolicyPresentationLongDecimalTextBox to create.</param>
        /// <returns>The created GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> CreateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationLongDecimalTextBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToCreate">The GroupPolicyPresentationLongDecimalTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> CreateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationLongDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationLongDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToUpdate">The GroupPolicyPresentationLongDecimalTextBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> UpdateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationLongDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationLongDecimalTextBoxToUpdate">The GroupPolicyPresentationLongDecimalTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentationLongDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationLongDecimalTextBox> UpdateAsync(GroupPolicyPresentationLongDecimalTextBox groupPolicyPresentationLongDecimalTextBoxToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationLongDecimalTextBoxRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationLongDecimalTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationLongDecimalTextBox, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationLongDecimalTextBoxRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationLongDecimalTextBoxRequest Select(Expression<Func<GroupPolicyPresentationLongDecimalTextBox, object>> selectExpression);

    }
}
