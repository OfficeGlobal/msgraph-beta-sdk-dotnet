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
    /// The interface IAndroidWorkProfileGmailEasConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileGmailEasConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileGmailEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToCreate">The AndroidWorkProfileGmailEasConfiguration to create.</param>
        /// <returns>The created AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> CreateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidWorkProfileGmailEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToCreate">The AndroidWorkProfileGmailEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> CreateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <returns>The AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileGmailEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidWorkProfileGmailEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToUpdate">The AndroidWorkProfileGmailEasConfiguration to update.</param>
        /// <returns>The updated AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> UpdateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidWorkProfileGmailEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileGmailEasConfigurationToUpdate">The AndroidWorkProfileGmailEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidWorkProfileGmailEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileGmailEasConfiguration> UpdateAsync(AndroidWorkProfileGmailEasConfiguration androidWorkProfileGmailEasConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Expand(Expression<Func<AndroidWorkProfileGmailEasConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileGmailEasConfigurationRequest Select(Expression<Func<AndroidWorkProfileGmailEasConfiguration, object>> selectExpression);

    }
}
