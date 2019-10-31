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
    /// The interface IApprovalWorkflowProviderRequestBuilder.
    /// </summary>
    public partial interface IApprovalWorkflowProviderRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IApprovalWorkflowProviderRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IApprovalWorkflowProviderRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for BusinessFlows.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder"/>.</returns>
        IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder BusinessFlows { get; }

        /// <summary>
        /// Gets the request builder for PolicyTemplates.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderPolicyTemplatesCollectionRequestBuilder"/>.</returns>
        IApprovalWorkflowProviderPolicyTemplatesCollectionRequestBuilder PolicyTemplates { get; }

        /// <summary>
        /// Gets the request builder for Requests.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderRequestsCollectionRequestBuilder"/>.</returns>
        IApprovalWorkflowProviderRequestsCollectionRequestBuilder Requests { get; }

        /// <summary>
        /// Gets the request builder for RequestsAwaitingMyDecision.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder"/>.</returns>
        IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder RequestsAwaitingMyDecision { get; }

        /// <summary>
        /// Gets the request builder for BusinessFlowsWithRequestsAwaitingMyDecision.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionRequestBuilder"/>.</returns>
        IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionRequestBuilder BusinessFlowsWithRequestsAwaitingMyDecision { get; }
    
    }
}