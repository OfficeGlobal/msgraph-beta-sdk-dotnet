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
    /// The type UserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder"/> for the specified UserWindowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <param name="id">The ID for the UserWindowsInformationProtectionDeviceRegistration.</param>
        /// <returns>The <see cref="IWindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new WindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserWindowsInformationProtectionDeviceRegistrationsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserWindowsInformationProtectionDeviceRegistrationsCollectionReferencesRequestBuilder"/>.</returns>
        public IUserWindowsInformationProtectionDeviceRegistrationsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserWindowsInformationProtectionDeviceRegistrationsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
