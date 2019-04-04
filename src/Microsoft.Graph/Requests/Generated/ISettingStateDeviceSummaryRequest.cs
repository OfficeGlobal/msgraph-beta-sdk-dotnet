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
    /// The interface ISettingStateDeviceSummaryRequest.
    /// </summary>
    public partial interface ISettingStateDeviceSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SettingStateDeviceSummary using PUT.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToCreate">The SettingStateDeviceSummary to create.</param>
        /// <returns>The created SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> CreateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToCreate);        /// <summary>
        /// Creates the specified SettingStateDeviceSummary using PUT.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToCreate">The SettingStateDeviceSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> CreateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SettingStateDeviceSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SettingStateDeviceSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SettingStateDeviceSummary.
        /// </summary>
        /// <returns>The SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> GetAsync();

        /// <summary>
        /// Gets the specified SettingStateDeviceSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PATCH.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary to update.</param>
        /// <returns>The updated SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> UpdateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate);

        /// <summary>
        /// Updates the specified SettingStateDeviceSummary using PATCH.
        /// </summary>
        /// <param name="settingStateDeviceSummaryToUpdate">The SettingStateDeviceSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> UpdateAsync(SettingStateDeviceSummary settingStateDeviceSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Expand(Expression<Func<SettingStateDeviceSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingStateDeviceSummaryRequest Select(Expression<Func<SettingStateDeviceSummary, object>> selectExpression);

    }
}
