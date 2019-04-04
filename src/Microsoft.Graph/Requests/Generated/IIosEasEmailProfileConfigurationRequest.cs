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
    /// The interface IIosEasEmailProfileConfigurationRequest.
    /// </summary>
    public partial interface IIosEasEmailProfileConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using PUT.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <returns>The created IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> CreateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate);        /// <summary>
        /// Creates the specified IosEasEmailProfileConfiguration using PUT.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToCreate">The IosEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> CreateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <returns>The IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <returns>The updated IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> UpdateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEasEmailProfileConfigurationToUpdate">The IosEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<IosEasEmailProfileConfiguration> UpdateAsync(IosEasEmailProfileConfiguration iosEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Expand(Expression<Func<IosEasEmailProfileConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEasEmailProfileConfigurationRequest Select(Expression<Func<IosEasEmailProfileConfiguration, object>> selectExpression);

    }
}
