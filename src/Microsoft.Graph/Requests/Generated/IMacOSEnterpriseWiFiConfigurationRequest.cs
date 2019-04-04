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
    /// The interface IMacOSEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial interface IMacOSEnterpriseWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSEnterpriseWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToCreate">The MacOSEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> CreateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSEnterpriseWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToCreate">The MacOSEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> CreateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToUpdate">The MacOSEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> UpdateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToUpdate">The MacOSEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MacOSEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> UpdateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEnterpriseWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEnterpriseWiFiConfigurationRequest Expand(Expression<Func<MacOSEnterpriseWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEnterpriseWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEnterpriseWiFiConfigurationRequest Select(Expression<Func<MacOSEnterpriseWiFiConfiguration, object>> selectExpression);

    }
}
