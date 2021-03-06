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
    /// The interface IPrivilegedAccessRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPrivilegedAccessRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPrivilegedAccessRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Resources.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessResourcesCollectionRequestBuilder"/>.</returns>
        IPrivilegedAccessResourcesCollectionRequestBuilder Resources { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        IPrivilegedAccessRoleDefinitionsCollectionRequestBuilder RoleDefinitions { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IPrivilegedAccessRoleAssignmentsCollectionRequestBuilder RoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignmentRequests.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessRoleAssignmentRequestsCollectionRequestBuilder"/>.</returns>
        IPrivilegedAccessRoleAssignmentRequestsCollectionRequestBuilder RoleAssignmentRequests { get; }

        /// <summary>
        /// Gets the request builder for RoleSettings.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessRoleSettingsCollectionRequestBuilder"/>.</returns>
        IPrivilegedAccessRoleSettingsCollectionRequestBuilder RoleSettings { get; }
    
    }
}
