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
    /// The interface IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedRoleAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedRoleAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedRoleAssignmentRequestBuilder"/> for the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedRoleAssignment.</param>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrivilegedRoleAssignmentMy.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentMyRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentMyRequestBuilder My();
    }
}
