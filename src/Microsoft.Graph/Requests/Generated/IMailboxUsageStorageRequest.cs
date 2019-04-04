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
    /// The interface IMailboxUsageStorageRequest.
    /// </summary>
    public partial interface IMailboxUsageStorageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MailboxUsageStorage using PUT.
        /// </summary>
        /// <param name="mailboxUsageStorageToCreate">The MailboxUsageStorage to create.</param>
        /// <returns>The created MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> CreateAsync(MailboxUsageStorage mailboxUsageStorageToCreate);        /// <summary>
        /// Creates the specified MailboxUsageStorage using PUT.
        /// </summary>
        /// <param name="mailboxUsageStorageToCreate">The MailboxUsageStorage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> CreateAsync(MailboxUsageStorage mailboxUsageStorageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MailboxUsageStorage.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MailboxUsageStorage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MailboxUsageStorage.
        /// </summary>
        /// <returns>The MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> GetAsync();

        /// <summary>
        /// Gets the specified MailboxUsageStorage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MailboxUsageStorage using PATCH.
        /// </summary>
        /// <param name="mailboxUsageStorageToUpdate">The MailboxUsageStorage to update.</param>
        /// <returns>The updated MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> UpdateAsync(MailboxUsageStorage mailboxUsageStorageToUpdate);

        /// <summary>
        /// Updates the specified MailboxUsageStorage using PATCH.
        /// </summary>
        /// <param name="mailboxUsageStorageToUpdate">The MailboxUsageStorage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MailboxUsageStorage.</returns>
        System.Threading.Tasks.Task<MailboxUsageStorage> UpdateAsync(MailboxUsageStorage mailboxUsageStorageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageStorageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageStorageRequest Expand(Expression<Func<MailboxUsageStorage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageStorageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageStorageRequest Select(Expression<Func<MailboxUsageStorage, object>> selectExpression);

    }
}
