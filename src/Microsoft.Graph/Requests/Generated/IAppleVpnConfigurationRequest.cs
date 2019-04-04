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
    /// The interface IAppleVpnConfigurationRequest.
    /// </summary>
    public partial interface IAppleVpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleVpnConfiguration using PUT.
        /// </summary>
        /// <param name="appleVpnConfigurationToCreate">The AppleVpnConfiguration to create.</param>
        /// <returns>The created AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> CreateAsync(AppleVpnConfiguration appleVpnConfigurationToCreate);        /// <summary>
        /// Creates the specified AppleVpnConfiguration using PUT.
        /// </summary>
        /// <param name="appleVpnConfigurationToCreate">The AppleVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> CreateAsync(AppleVpnConfiguration appleVpnConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AppleVpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AppleVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AppleVpnConfiguration.
        /// </summary>
        /// <returns>The AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AppleVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AppleVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="appleVpnConfigurationToUpdate">The AppleVpnConfiguration to update.</param>
        /// <returns>The updated AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> UpdateAsync(AppleVpnConfiguration appleVpnConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AppleVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="appleVpnConfigurationToUpdate">The AppleVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AppleVpnConfiguration.</returns>
        System.Threading.Tasks.Task<AppleVpnConfiguration> UpdateAsync(AppleVpnConfiguration appleVpnConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVpnConfigurationRequest Expand(Expression<Func<AppleVpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleVpnConfigurationRequest Select(Expression<Func<AppleVpnConfiguration, object>> selectExpression);

    }
}
