// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOfficeConfigurationClientConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IOfficeConfigurationClientConfigurationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOfficeConfigurationClientConfigurationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOfficeConfigurationClientConfigurationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IOfficeClientConfigurationRequestBuilder"/> for the specified OfficeClientConfiguration.
        /// </summary>
        /// <param name="id">The ID for the OfficeClientConfiguration.</param>
        /// <returns>The <see cref="IOfficeClientConfigurationRequestBuilder"/>.</returns>
        IOfficeClientConfigurationRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for OfficeClientConfigurationUpdatePriorities.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationUpdatePrioritiesRequestBuilder"/>.</returns>
        IOfficeClientConfigurationUpdatePrioritiesRequestBuilder UpdatePriorities(
            IEnumerable<Int32> officeConfigurationPriorities,
            IEnumerable<string> officeConfigurationPolicyIds = null);
    }
}
