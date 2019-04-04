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
    /// The type EducationUserRequestBuilder.
    /// </summary>
    public partial class EducationUserRequestBuilder : EntityRequestBuilder, IEducationUserRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationUserRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationUserRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEducationUserRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEducationUserRequest Request(IEnumerable<Option> options)
        {
            return new EducationUserRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Schools.
        /// </summary>
        /// <returns>The <see cref="IEducationUserSchoolsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IEducationUserSchoolsCollectionWithReferencesRequestBuilder Schools
        {
            get
            {
                return new EducationUserSchoolsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("schools"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Classes.
        /// </summary>
        /// <returns>The <see cref="IEducationUserClassesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IEducationUserClassesCollectionWithReferencesRequestBuilder Classes
        {
            get
            {
                return new EducationUserClassesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("classes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for User.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        public IUserWithReferenceRequestBuilder User
        {
            get
            {
                return new UserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("user"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IEducationUserAssignmentsCollectionRequestBuilder"/>.</returns>
        public IEducationUserAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new EducationUserAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
    }
}
