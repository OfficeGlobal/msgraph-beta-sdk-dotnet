// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAppRoleAssignmentWithReferenceRequestBuilder"/> for the specified ServicePrincipalAppRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalAppRoleAssignment.</param>
        /// <returns>The <see cref="IAppRoleAssignmentWithReferenceRequestBuilder"/>.</returns>
        public IAppRoleAssignmentWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new AppRoleAssignmentWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
