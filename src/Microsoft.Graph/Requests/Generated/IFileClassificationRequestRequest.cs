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
    /// The interface IFileClassificationRequestRequest.
    /// </summary>
    public partial interface IFileClassificationRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FileClassificationRequestObject using PUT.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToCreate">The FileClassificationRequestObject to create.</param>
        /// <returns>The created FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> CreateAsync(FileClassificationRequestObject fileClassificationRequestObjectToCreate);        /// <summary>
        /// Creates the specified FileClassificationRequestObject using PUT.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToCreate">The FileClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> CreateAsync(FileClassificationRequestObject fileClassificationRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified FileClassificationRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified FileClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified FileClassificationRequestObject.
        /// </summary>
        /// <returns>The FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified FileClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified FileClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToUpdate">The FileClassificationRequestObject to update.</param>
        /// <returns>The updated FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> UpdateAsync(FileClassificationRequestObject fileClassificationRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified FileClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToUpdate">The FileClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> UpdateAsync(FileClassificationRequestObject fileClassificationRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Expand(Expression<Func<FileClassificationRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Select(Expression<Func<FileClassificationRequestObject, object>> selectExpression);

    }
}
