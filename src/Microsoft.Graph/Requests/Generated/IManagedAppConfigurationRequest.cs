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
    /// The interface IManagedAppConfigurationRequest.
    /// </summary>
    public partial interface IManagedAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppConfiguration using PUT.
        /// </summary>
        /// <param name="managedAppConfigurationToCreate">The ManagedAppConfiguration to create.</param>
        /// <returns>The created ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> CreateAsync(ManagedAppConfiguration managedAppConfigurationToCreate);        /// <summary>
        /// Creates the specified ManagedAppConfiguration using PUT.
        /// </summary>
        /// <param name="managedAppConfigurationToCreate">The ManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> CreateAsync(ManagedAppConfiguration managedAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppConfiguration.
        /// </summary>
        /// <returns>The ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="managedAppConfigurationToUpdate">The ManagedAppConfiguration to update.</param>
        /// <returns>The updated ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> UpdateAsync(ManagedAppConfiguration managedAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="managedAppConfigurationToUpdate">The ManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedAppConfiguration> UpdateAsync(ManagedAppConfiguration managedAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppConfigurationRequest Expand(Expression<Func<ManagedAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppConfigurationRequest Select(Expression<Func<ManagedAppConfiguration, object>> selectExpression);

    }
}
