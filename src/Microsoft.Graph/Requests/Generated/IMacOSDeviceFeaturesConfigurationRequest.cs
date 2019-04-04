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
    /// The interface IMacOSDeviceFeaturesConfigurationRequest.
    /// </summary>
    public partial interface IMacOSDeviceFeaturesConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSDeviceFeaturesConfiguration using PUT.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToCreate">The MacOSDeviceFeaturesConfiguration to create.</param>
        /// <returns>The created MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> CreateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSDeviceFeaturesConfiguration using PUT.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToCreate">The MacOSDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> CreateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <returns>The MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToUpdate">The MacOSDeviceFeaturesConfiguration to update.</param>
        /// <returns>The updated MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> UpdateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToUpdate">The MacOSDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> UpdateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Expand(Expression<Func<MacOSDeviceFeaturesConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Select(Expression<Func<MacOSDeviceFeaturesConfiguration, object>> selectExpression);

    }
}
