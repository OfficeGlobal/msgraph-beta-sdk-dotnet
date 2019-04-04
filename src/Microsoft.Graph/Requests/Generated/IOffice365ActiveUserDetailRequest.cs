// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOffice365ActiveUserDetailRequest.
    /// </summary>
    public partial interface IOffice365ActiveUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Office365ActiveUserDetail using PUT.
        /// </summary>
        /// <param name="office365ActiveUserDetailToCreate">The Office365ActiveUserDetail to create.</param>
        /// <returns>The created Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> CreateAsync(Office365ActiveUserDetail office365ActiveUserDetailToCreate);        /// <summary>
        /// Creates the specified Office365ActiveUserDetail using PUT.
        /// </summary>
        /// <param name="office365ActiveUserDetailToCreate">The Office365ActiveUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> CreateAsync(Office365ActiveUserDetail office365ActiveUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Office365ActiveUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Office365ActiveUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Office365ActiveUserDetail.
        /// </summary>
        /// <returns>The Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified Office365ActiveUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Office365ActiveUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActiveUserDetailToUpdate">The Office365ActiveUserDetail to update.</param>
        /// <returns>The updated Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> UpdateAsync(Office365ActiveUserDetail office365ActiveUserDetailToUpdate);

        /// <summary>
        /// Updates the specified Office365ActiveUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActiveUserDetailToUpdate">The Office365ActiveUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Office365ActiveUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActiveUserDetail> UpdateAsync(Office365ActiveUserDetail office365ActiveUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActiveUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActiveUserDetailRequest Expand(Expression<Func<Office365ActiveUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActiveUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActiveUserDetailRequest Select(Expression<Func<Office365ActiveUserDetail, object>> selectExpression);

    }
}
