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
    /// The interface IWindowsPhone81VpnConfigurationRequestBuilder.
    /// </summary>
    public partial interface IWindowsPhone81VpnConfigurationRequestBuilder : IWindows81VpnConfigurationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWindowsPhone81VpnConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWindowsPhone81VpnConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for IdentityCertificate.
        /// </summary>
        /// <returns>The <see cref="IWindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder"/>.</returns>
        IWindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder IdentityCertificate { get; }
    
    }
}
