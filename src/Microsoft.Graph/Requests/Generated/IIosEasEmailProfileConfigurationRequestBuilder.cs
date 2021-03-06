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
    /// The interface IIosEasEmailProfileConfigurationRequestBuilder.
    /// </summary>
    public partial interface IIosEasEmailProfileConfigurationRequestBuilder : IEasEmailProfileConfigurationBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IIosEasEmailProfileConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IIosEasEmailProfileConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for IdentityCertificate.
        /// </summary>
        /// <returns>The <see cref="IIosCertificateProfileBaseWithReferenceRequestBuilder"/>.</returns>
        IIosCertificateProfileBaseWithReferenceRequestBuilder IdentityCertificate { get; }

        /// <summary>
        /// Gets the request builder for SmimeSigningCertificate.
        /// </summary>
        /// <returns>The <see cref="IIosCertificateProfileWithReferenceRequestBuilder"/>.</returns>
        IIosCertificateProfileWithReferenceRequestBuilder SmimeSigningCertificate { get; }

        /// <summary>
        /// Gets the request builder for SmimeEncryptionCertificate.
        /// </summary>
        /// <returns>The <see cref="IIosCertificateProfileWithReferenceRequestBuilder"/>.</returns>
        IIosCertificateProfileWithReferenceRequestBuilder SmimeEncryptionCertificate { get; }

        /// <summary>
        /// Gets the request builder for DerivedCredentialSettings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder"/>.</returns>
        IDeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder DerivedCredentialSettings { get; }
    
    }
}
