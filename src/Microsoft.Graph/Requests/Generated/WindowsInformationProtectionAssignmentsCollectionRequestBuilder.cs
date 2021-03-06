// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsInformationProtectionAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsInformationProtectionAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IWindowsInformationProtectionAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsInformationProtectionAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsInformationProtectionAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITargetedManagedAppPolicyAssignmentRequestBuilder"/> for the specified WindowsInformationProtectionTargetedManagedAppPolicyAssignment.
        /// </summary>
        /// <param name="id">The ID for the WindowsInformationProtectionTargetedManagedAppPolicyAssignment.</param>
        /// <returns>The <see cref="ITargetedManagedAppPolicyAssignmentRequestBuilder"/>.</returns>
        public ITargetedManagedAppPolicyAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new TargetedManagedAppPolicyAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
