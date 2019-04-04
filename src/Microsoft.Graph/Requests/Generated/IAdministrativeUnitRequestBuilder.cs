// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAdministrativeUnitRequestBuilder.
    /// </summary>
    public partial interface IAdministrativeUnitRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAdministrativeUnitRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAdministrativeUnitRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IAdministrativeUnitExtensionsCollectionRequestBuilder"/>.</returns>
        IAdministrativeUnitExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IAdministrativeUnitMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IAdministrativeUnitMembersCollectionWithReferencesRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for ScopedRoleMembers.
        /// </summary>
        /// <returns>The <see cref="IAdministrativeUnitScopedRoleMembersCollectionRequestBuilder"/>.</returns>
        IAdministrativeUnitScopedRoleMembersCollectionRequestBuilder ScopedRoleMembers { get; }
    
        
    
    }
}
