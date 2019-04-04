// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WindowsUpdateForBusinessConfigurationRequestBuilder.
    /// </summary>
    public partial class WindowsUpdateForBusinessConfigurationRequestBuilder : DeviceConfigurationRequestBuilder, IWindowsUpdateForBusinessConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsUpdateForBusinessConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsUpdateForBusinessConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsUpdateForBusinessConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsUpdateForBusinessConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new WindowsUpdateForBusinessConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WindowsUpdateForBusinessConfigurationExtendFeatureUpdatesPause.
        /// </summary>
        /// <returns>The <see cref="IWindowsUpdateForBusinessConfigurationExtendFeatureUpdatesPauseRequestBuilder"/>.</returns>
        public IWindowsUpdateForBusinessConfigurationExtendFeatureUpdatesPauseRequestBuilder ExtendFeatureUpdatesPause()
        {
            return new WindowsUpdateForBusinessConfigurationExtendFeatureUpdatesPauseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.extendFeatureUpdatesPause"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WindowsUpdateForBusinessConfigurationExtendQualityUpdatesPause.
        /// </summary>
        /// <returns>The <see cref="IWindowsUpdateForBusinessConfigurationExtendQualityUpdatesPauseRequestBuilder"/>.</returns>
        public IWindowsUpdateForBusinessConfigurationExtendQualityUpdatesPauseRequestBuilder ExtendQualityUpdatesPause()
        {
            return new WindowsUpdateForBusinessConfigurationExtendQualityUpdatesPauseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.extendQualityUpdatesPause"),
                this.Client);
        }
    
    }
}
