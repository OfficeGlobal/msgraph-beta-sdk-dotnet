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
    /// The type ManagementConditionStatementRequestBuilder.
    /// </summary>
    public partial class ManagementConditionStatementRequestBuilder : EntityRequestBuilder, IManagementConditionStatementRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagementConditionStatementRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagementConditionStatementRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagementConditionStatementRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagementConditionStatementRequest Request(IEnumerable<Option> options)
        {
            return new ManagementConditionStatementRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ManagementConditions.
        /// </summary>
        /// <returns>The <see cref="IManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder ManagementConditions
        {
            get
            {
                return new ManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("managementConditions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ManagementConditionStatementGetManagementConditionStatementExpressionString.
        /// </summary>
        /// <returns>The <see cref="IManagementConditionStatementGetManagementConditionStatementExpressionStringRequestBuilder"/>.</returns>
        public IManagementConditionStatementGetManagementConditionStatementExpressionStringRequestBuilder GetManagementConditionStatementExpressionString()
        {
            return new ManagementConditionStatementGetManagementConditionStatementExpressionStringRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getManagementConditionStatementExpressionString"),
                this.Client);
        }
    
    }
}
