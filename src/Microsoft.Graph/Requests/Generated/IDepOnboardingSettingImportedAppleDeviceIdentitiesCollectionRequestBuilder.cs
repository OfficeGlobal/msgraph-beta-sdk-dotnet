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
    /// The interface IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IImportedAppleDeviceIdentityRequestBuilder"/> for the specified ImportedAppleDeviceIdentity.
        /// </summary>
        /// <param name="id">The ID for the ImportedAppleDeviceIdentity.</param>
        /// <returns>The <see cref="IImportedAppleDeviceIdentityRequestBuilder"/>.</returns>
        IImportedAppleDeviceIdentityRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ImportedAppleDeviceIdentityImportAppleDeviceIdentityList.
        /// </summary>
        /// <returns>The <see cref="IImportedAppleDeviceIdentityImportAppleDeviceIdentityListRequestBuilder"/>.</returns>
        IImportedAppleDeviceIdentityImportAppleDeviceIdentityListRequestBuilder ImportAppleDeviceIdentityList(
            bool overwriteImportedDeviceIdentities,
            IEnumerable<ImportedAppleDeviceIdentity> importedAppleDeviceIdentities = null);
    }
}
