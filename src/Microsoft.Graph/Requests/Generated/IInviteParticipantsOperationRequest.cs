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
    /// The interface IInviteParticipantsOperationRequest.
    /// </summary>
    public partial interface IInviteParticipantsOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InviteParticipantsOperation using PUT.
        /// </summary>
        /// <param name="inviteParticipantsOperationToCreate">The InviteParticipantsOperation to create.</param>
        /// <returns>The created InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> CreateAsync(InviteParticipantsOperation inviteParticipantsOperationToCreate);        /// <summary>
        /// Creates the specified InviteParticipantsOperation using PUT.
        /// </summary>
        /// <param name="inviteParticipantsOperationToCreate">The InviteParticipantsOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> CreateAsync(InviteParticipantsOperation inviteParticipantsOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified InviteParticipantsOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified InviteParticipantsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified InviteParticipantsOperation.
        /// </summary>
        /// <returns>The InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> GetAsync();

        /// <summary>
        /// Gets the specified InviteParticipantsOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PATCH.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation to update.</param>
        /// <returns>The updated InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> UpdateAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate);

        /// <summary>
        /// Updates the specified InviteParticipantsOperation using PATCH.
        /// </summary>
        /// <param name="inviteParticipantsOperationToUpdate">The InviteParticipantsOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated InviteParticipantsOperation.</returns>
        System.Threading.Tasks.Task<InviteParticipantsOperation> UpdateAsync(InviteParticipantsOperation inviteParticipantsOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Expand(Expression<Func<InviteParticipantsOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInviteParticipantsOperationRequest Select(Expression<Func<InviteParticipantsOperation, object>> selectExpression);

    }
}
