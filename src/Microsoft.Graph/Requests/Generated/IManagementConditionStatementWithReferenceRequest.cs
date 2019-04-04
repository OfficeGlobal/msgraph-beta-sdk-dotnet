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
    /// The interface IManagementConditionStatementWithReferenceRequest.
    /// </summary>
    public partial interface IManagementConditionStatementWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified ManagementConditionStatement.
        /// </summary>
        /// <returns>The ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> GetAsync();

        /// <summary>
        /// Gets the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified ManagementConditionStatement using PUT.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <returns>The created ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> CreateAsync(ManagementConditionStatement managementConditionStatementToCreate);        /// <summary>
        /// Creates the specified ManagementConditionStatement using PUT.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> CreateAsync(ManagementConditionStatement managementConditionStatementToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <returns>The updated ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> UpdateAsync(ManagementConditionStatement managementConditionStatementToUpdate);

        /// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> UpdateAsync(ManagementConditionStatement managementConditionStatementToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified ManagementConditionStatement.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementWithReferenceRequest Expand(Expression<Func<ManagementConditionStatement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementWithReferenceRequest Select(Expression<Func<ManagementConditionStatement, object>> selectExpression);

    }
}
