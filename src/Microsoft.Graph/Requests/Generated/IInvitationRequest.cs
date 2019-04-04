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
    /// The interface IInvitationRequest.
    /// </summary>
    public partial interface IInvitationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Invitation using PUT.
        /// </summary>
        /// <param name="invitationToCreate">The Invitation to create.</param>
        /// <returns>The created Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> CreateAsync(Invitation invitationToCreate);        /// <summary>
        /// Creates the specified Invitation using PUT.
        /// </summary>
        /// <param name="invitationToCreate">The Invitation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> CreateAsync(Invitation invitationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Invitation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Invitation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Invitation.
        /// </summary>
        /// <returns>The Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> GetAsync();

        /// <summary>
        /// Gets the specified Invitation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Invitation using PATCH.
        /// </summary>
        /// <param name="invitationToUpdate">The Invitation to update.</param>
        /// <returns>The updated Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> UpdateAsync(Invitation invitationToUpdate);

        /// <summary>
        /// Updates the specified Invitation using PATCH.
        /// </summary>
        /// <param name="invitationToUpdate">The Invitation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Invitation.</returns>
        System.Threading.Tasks.Task<Invitation> UpdateAsync(Invitation invitationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInvitationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInvitationRequest Expand(Expression<Func<Invitation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInvitationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInvitationRequest Select(Expression<Func<Invitation, object>> selectExpression);

    }
}
