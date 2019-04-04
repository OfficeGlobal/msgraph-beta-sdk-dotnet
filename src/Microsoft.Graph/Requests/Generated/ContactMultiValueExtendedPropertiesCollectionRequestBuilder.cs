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
    /// The type ContactMultiValueExtendedPropertiesCollectionRequestBuilder.
    /// </summary>
    public partial class ContactMultiValueExtendedPropertiesCollectionRequestBuilder : BaseRequestBuilder, IContactMultiValueExtendedPropertiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ContactMultiValueExtendedPropertiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContactMultiValueExtendedPropertiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IContactMultiValueExtendedPropertiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IContactMultiValueExtendedPropertiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ContactMultiValueExtendedPropertiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/> for the specified ContactMultiValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="id">The ID for the ContactMultiValueLegacyExtendedProperty.</param>
        /// <returns>The <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/>.</returns>
        public IMultiValueLegacyExtendedPropertyRequestBuilder this[string id]
        {
            get
            {
                return new MultiValueLegacyExtendedPropertyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
