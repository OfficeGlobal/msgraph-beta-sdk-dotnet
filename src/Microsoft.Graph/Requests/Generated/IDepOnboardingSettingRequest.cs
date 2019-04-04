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
    /// The interface IDepOnboardingSettingRequest.
    /// </summary>
    public partial interface IDepOnboardingSettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DepOnboardingSetting using PUT.
        /// </summary>
        /// <param name="depOnboardingSettingToCreate">The DepOnboardingSetting to create.</param>
        /// <returns>The created DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> CreateAsync(DepOnboardingSetting depOnboardingSettingToCreate);        /// <summary>
        /// Creates the specified DepOnboardingSetting using PUT.
        /// </summary>
        /// <param name="depOnboardingSettingToCreate">The DepOnboardingSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> CreateAsync(DepOnboardingSetting depOnboardingSettingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DepOnboardingSetting.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DepOnboardingSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DepOnboardingSetting.
        /// </summary>
        /// <returns>The DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> GetAsync();

        /// <summary>
        /// Gets the specified DepOnboardingSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DepOnboardingSetting using PATCH.
        /// </summary>
        /// <param name="depOnboardingSettingToUpdate">The DepOnboardingSetting to update.</param>
        /// <returns>The updated DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> UpdateAsync(DepOnboardingSetting depOnboardingSettingToUpdate);

        /// <summary>
        /// Updates the specified DepOnboardingSetting using PATCH.
        /// </summary>
        /// <param name="depOnboardingSettingToUpdate">The DepOnboardingSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DepOnboardingSetting.</returns>
        System.Threading.Tasks.Task<DepOnboardingSetting> UpdateAsync(DepOnboardingSetting depOnboardingSettingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepOnboardingSettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepOnboardingSettingRequest Expand(Expression<Func<DepOnboardingSetting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDepOnboardingSettingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDepOnboardingSettingRequest Select(Expression<Func<DepOnboardingSetting, object>> selectExpression);

    }
}
