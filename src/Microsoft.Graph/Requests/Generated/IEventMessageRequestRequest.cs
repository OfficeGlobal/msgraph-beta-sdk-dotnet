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
    /// The interface IEventMessageRequestRequest.
    /// </summary>
    public partial interface IEventMessageRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EventMessageRequestObject using PUT.
        /// </summary>
        /// <param name="eventMessageRequestObjectToCreate">The EventMessageRequestObject to create.</param>
        /// <returns>The created EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> CreateAsync(EventMessageRequestObject eventMessageRequestObjectToCreate);        /// <summary>
        /// Creates the specified EventMessageRequestObject using PUT.
        /// </summary>
        /// <param name="eventMessageRequestObjectToCreate">The EventMessageRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> CreateAsync(EventMessageRequestObject eventMessageRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EventMessageRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EventMessageRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EventMessageRequestObject.
        /// </summary>
        /// <returns>The EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified EventMessageRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EventMessageRequestObject using PATCH.
        /// </summary>
        /// <param name="eventMessageRequestObjectToUpdate">The EventMessageRequestObject to update.</param>
        /// <returns>The updated EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> UpdateAsync(EventMessageRequestObject eventMessageRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified EventMessageRequestObject using PATCH.
        /// </summary>
        /// <param name="eventMessageRequestObjectToUpdate">The EventMessageRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EventMessageRequestObject.</returns>
        System.Threading.Tasks.Task<EventMessageRequestObject> UpdateAsync(EventMessageRequestObject eventMessageRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequestRequest Expand(Expression<Func<EventMessageRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEventMessageRequestRequest Select(Expression<Func<EventMessageRequestObject, object>> selectExpression);

    }
}
