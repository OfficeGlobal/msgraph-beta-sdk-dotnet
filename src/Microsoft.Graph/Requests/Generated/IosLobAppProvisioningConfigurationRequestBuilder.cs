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
    /// The type IosLobAppProvisioningConfigurationRequestBuilder.
    /// </summary>
    public partial class IosLobAppProvisioningConfigurationRequestBuilder : EntityRequestBuilder, IIosLobAppProvisioningConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new IosLobAppProvisioningConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IosLobAppProvisioningConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IIosLobAppProvisioningConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IIosLobAppProvisioningConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new IosLobAppProvisioningConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IIosLobAppProvisioningConfigurationGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        public IIosLobAppProvisioningConfigurationGroupAssignmentsCollectionRequestBuilder GroupAssignments
        {
            get
            {
                return new IosLobAppProvisioningConfigurationGroupAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groupAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IIosLobAppProvisioningConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IIosLobAppProvisioningConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new IosLobAppProvisioningConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IIosLobAppProvisioningConfigurationDeviceStatusesCollectionRequestBuilder"/>.</returns>
        public IIosLobAppProvisioningConfigurationDeviceStatusesCollectionRequestBuilder DeviceStatuses
        {
            get
            {
                return new IosLobAppProvisioningConfigurationDeviceStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IIosLobAppProvisioningConfigurationUserStatusesCollectionRequestBuilder"/>.</returns>
        public IIosLobAppProvisioningConfigurationUserStatusesCollectionRequestBuilder UserStatuses
        {
            get
            {
                return new IosLobAppProvisioningConfigurationUserStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStatuses"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for IosLobAppProvisioningConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IIosLobAppProvisioningConfigurationAssignRequestBuilder"/>.</returns>
        public IIosLobAppProvisioningConfigurationAssignRequestBuilder Assign(
            IEnumerable<MobileAppProvisioningConfigGroupAssignment> appProvisioningConfigurationGroupAssignments = null,
            IEnumerable<IosLobAppProvisioningConfigurationAssignment> iOSLobAppProvisioningConfigAssignments = null)
        {
            return new IosLobAppProvisioningConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                appProvisioningConfigurationGroupAssignments,
                iOSLobAppProvisioningConfigAssignments);
        }
    
    }
}
