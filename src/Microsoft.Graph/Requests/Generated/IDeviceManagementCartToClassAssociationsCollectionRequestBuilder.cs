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
    /// The interface IDeviceManagementCartToClassAssociationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementCartToClassAssociationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementCartToClassAssociationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementCartToClassAssociationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICartToClassAssociationRequestBuilder"/> for the specified CartToClassAssociation.
        /// </summary>
        /// <param name="id">The ID for the CartToClassAssociation.</param>
        /// <returns>The <see cref="ICartToClassAssociationRequestBuilder"/>.</returns>
        ICartToClassAssociationRequestBuilder this[string id] { get; }

        
    }
}
