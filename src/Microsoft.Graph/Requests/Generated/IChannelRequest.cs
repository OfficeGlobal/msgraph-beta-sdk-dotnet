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
    /// The interface IChannelRequest.
    /// </summary>
    public partial interface IChannelRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Channel using PUT.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <returns>The created Channel.</returns>
        System.Threading.Tasks.Task<Channel> CreateAsync(Channel channelToCreate);        /// <summary>
        /// Creates the specified Channel using PUT.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Channel.</returns>
        System.Threading.Tasks.Task<Channel> CreateAsync(Channel channelToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Channel.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Channel.
        /// </summary>
        /// <returns>The Channel.</returns>
        System.Threading.Tasks.Task<Channel> GetAsync();

        /// <summary>
        /// Gets the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Channel.</returns>
        System.Threading.Tasks.Task<Channel> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Channel using PATCH.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <returns>The updated Channel.</returns>
        System.Threading.Tasks.Task<Channel> UpdateAsync(Channel channelToUpdate);

        /// <summary>
        /// Updates the specified Channel using PATCH.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Channel.</returns>
        System.Threading.Tasks.Task<Channel> UpdateAsync(Channel channelToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelRequest Expand(Expression<Func<Channel, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelRequest Select(Expression<Func<Channel, object>> selectExpression);

    }
}
