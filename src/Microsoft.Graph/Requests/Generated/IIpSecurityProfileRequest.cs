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
    /// The interface IIpSecurityProfileRequest.
    /// </summary>
    public partial interface IIpSecurityProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IpSecurityProfile using PUT.
        /// </summary>
        /// <param name="ipSecurityProfileToCreate">The IpSecurityProfile to create.</param>
        /// <returns>The created IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> CreateAsync(IpSecurityProfile ipSecurityProfileToCreate);        /// <summary>
        /// Creates the specified IpSecurityProfile using PUT.
        /// </summary>
        /// <param name="ipSecurityProfileToCreate">The IpSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> CreateAsync(IpSecurityProfile ipSecurityProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IpSecurityProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IpSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IpSecurityProfile.
        /// </summary>
        /// <returns>The IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> GetAsync();

        /// <summary>
        /// Gets the specified IpSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IpSecurityProfile using PATCH.
        /// </summary>
        /// <param name="ipSecurityProfileToUpdate">The IpSecurityProfile to update.</param>
        /// <returns>The updated IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> UpdateAsync(IpSecurityProfile ipSecurityProfileToUpdate);

        /// <summary>
        /// Updates the specified IpSecurityProfile using PATCH.
        /// </summary>
        /// <param name="ipSecurityProfileToUpdate">The IpSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> UpdateAsync(IpSecurityProfile ipSecurityProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Expand(Expression<Func<IpSecurityProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Select(Expression<Func<IpSecurityProfile, object>> selectExpression);

    }
}
