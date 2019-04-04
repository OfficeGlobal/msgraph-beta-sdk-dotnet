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
    /// The interface ITextClassificationRequestRequest.
    /// </summary>
    public partial interface ITextClassificationRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TextClassificationRequestObject using PUT.
        /// </summary>
        /// <param name="textClassificationRequestObjectToCreate">The TextClassificationRequestObject to create.</param>
        /// <returns>The created TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> CreateAsync(TextClassificationRequestObject textClassificationRequestObjectToCreate);        /// <summary>
        /// Creates the specified TextClassificationRequestObject using PUT.
        /// </summary>
        /// <param name="textClassificationRequestObjectToCreate">The TextClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> CreateAsync(TextClassificationRequestObject textClassificationRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TextClassificationRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TextClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TextClassificationRequestObject.
        /// </summary>
        /// <returns>The TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified TextClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject to update.</param>
        /// <returns>The updated TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> UpdateAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified TextClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="textClassificationRequestObjectToUpdate">The TextClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TextClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<TextClassificationRequestObject> UpdateAsync(TextClassificationRequestObject textClassificationRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITextClassificationRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITextClassificationRequestRequest Expand(Expression<Func<TextClassificationRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITextClassificationRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITextClassificationRequestRequest Select(Expression<Func<TextClassificationRequestObject, object>> selectExpression);

    }
}
