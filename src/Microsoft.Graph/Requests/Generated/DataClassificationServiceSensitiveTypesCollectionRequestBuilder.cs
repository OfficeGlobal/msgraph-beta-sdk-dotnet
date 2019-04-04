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
    /// The type DataClassificationServiceSensitiveTypesCollectionRequestBuilder.
    /// </summary>
    public partial class DataClassificationServiceSensitiveTypesCollectionRequestBuilder : BaseRequestBuilder, IDataClassificationServiceSensitiveTypesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DataClassificationServiceSensitiveTypesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DataClassificationServiceSensitiveTypesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDataClassificationServiceSensitiveTypesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDataClassificationServiceSensitiveTypesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DataClassificationServiceSensitiveTypesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISensitiveTypeRequestBuilder"/> for the specified DataClassificationServiceSensitiveType.
        /// </summary>
        /// <param name="id">The ID for the DataClassificationServiceSensitiveType.</param>
        /// <returns>The <see cref="ISensitiveTypeRequestBuilder"/>.</returns>
        public ISensitiveTypeRequestBuilder this[string id]
        {
            get
            {
                return new SensitiveTypeRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
