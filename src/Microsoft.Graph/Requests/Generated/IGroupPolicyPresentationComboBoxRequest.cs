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
    /// The interface IGroupPolicyPresentationComboBoxRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationComboBoxRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationComboBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToCreate">The GroupPolicyPresentationComboBox to create.</param>
        /// <returns>The created GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> CreateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationComboBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToCreate">The GroupPolicyPresentationComboBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> CreateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> UpdateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentationComboBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> UpdateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationComboBoxRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationComboBoxRequest Expand(Expression<Func<GroupPolicyPresentationComboBox, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationComboBoxRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationComboBoxRequest Select(Expression<Func<GroupPolicyPresentationComboBox, object>> selectExpression);

    }
}
