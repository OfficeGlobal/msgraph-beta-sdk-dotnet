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
    /// The interface ISkypeForBusinessDeviceUsageUserDetailRequest.
    /// </summary>
    public partial interface ISkypeForBusinessDeviceUsageUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageUserDetail using PUT.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageUserDetailToCreate">The SkypeForBusinessDeviceUsageUserDetail to create.</param>
        /// <returns>The created SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> CreateAsync(SkypeForBusinessDeviceUsageUserDetail skypeForBusinessDeviceUsageUserDetailToCreate);        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageUserDetail using PUT.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageUserDetailToCreate">The SkypeForBusinessDeviceUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> CreateAsync(SkypeForBusinessDeviceUsageUserDetail skypeForBusinessDeviceUsageUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageUserDetailToUpdate">The SkypeForBusinessDeviceUsageUserDetail to update.</param>
        /// <returns>The updated SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> UpdateAsync(SkypeForBusinessDeviceUsageUserDetail skypeForBusinessDeviceUsageUserDetailToUpdate);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageUserDetailToUpdate">The SkypeForBusinessDeviceUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SkypeForBusinessDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageUserDetail> UpdateAsync(SkypeForBusinessDeviceUsageUserDetail skypeForBusinessDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageUserDetailRequest Expand(Expression<Func<SkypeForBusinessDeviceUsageUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageUserDetailRequest Select(Expression<Func<SkypeForBusinessDeviceUsageUserDetail, object>> selectExpression);

    }
}
