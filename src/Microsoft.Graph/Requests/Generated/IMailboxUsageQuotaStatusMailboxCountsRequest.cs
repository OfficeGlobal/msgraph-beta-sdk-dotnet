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
    /// The interface IMailboxUsageQuotaStatusMailboxCountsRequest.
    /// </summary>
    public partial interface IMailboxUsageQuotaStatusMailboxCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using PUT.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <returns>The created MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> CreateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate);        /// <summary>
        /// Creates the specified MailboxUsageQuotaStatusMailboxCounts using PUT.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToCreate">The MailboxUsageQuotaStatusMailboxCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> CreateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <returns>The MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> GetAsync();

        /// <summary>
        /// Gets the specified MailboxUsageQuotaStatusMailboxCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <returns>The updated MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> UpdateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate);

        /// <summary>
        /// Updates the specified MailboxUsageQuotaStatusMailboxCounts using PATCH.
        /// </summary>
        /// <param name="mailboxUsageQuotaStatusMailboxCountsToUpdate">The MailboxUsageQuotaStatusMailboxCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MailboxUsageQuotaStatusMailboxCounts.</returns>
        System.Threading.Tasks.Task<MailboxUsageQuotaStatusMailboxCounts> UpdateAsync(MailboxUsageQuotaStatusMailboxCounts mailboxUsageQuotaStatusMailboxCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageQuotaStatusMailboxCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageQuotaStatusMailboxCountsRequest Expand(Expression<Func<MailboxUsageQuotaStatusMailboxCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageQuotaStatusMailboxCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMailboxUsageQuotaStatusMailboxCountsRequest Select(Expression<Func<MailboxUsageQuotaStatusMailboxCounts, object>> selectExpression);

    }
}
