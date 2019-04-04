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
    /// The interface IEmailActivityUserDetailRequest.
    /// </summary>
    public partial interface IEmailActivityUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailActivityUserDetail using PUT.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <returns>The created EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> CreateAsync(EmailActivityUserDetail emailActivityUserDetailToCreate);        /// <summary>
        /// Creates the specified EmailActivityUserDetail using PUT.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> CreateAsync(EmailActivityUserDetail emailActivityUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EmailActivityUserDetail.
        /// </summary>
        /// <returns>The EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <returns>The updated EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> UpdateAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate);

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> UpdateAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Expand(Expression<Func<EmailActivityUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Select(Expression<Func<EmailActivityUserDetail, object>> selectExpression);

    }
}
