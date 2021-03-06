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
    /// The interface IDeviceManagementEmbeddedSIMActivationCodePoolsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementEmbeddedSIMActivationCodePoolsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementEmbeddedSIMActivationCodePoolsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementEmbeddedSIMActivationCodePoolsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEmbeddedSIMActivationCodePoolRequestBuilder"/> for the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <param name="id">The ID for the EmbeddedSIMActivationCodePool.</param>
        /// <returns>The <see cref="IEmbeddedSIMActivationCodePoolRequestBuilder"/>.</returns>
        IEmbeddedSIMActivationCodePoolRequestBuilder this[string id] { get; }

        
    }
}
