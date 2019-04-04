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
    /// The interface ICustomerPaymentRequest.
    /// </summary>
    public partial interface ICustomerPaymentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CustomerPayment using PUT.
        /// </summary>
        /// <param name="customerPaymentToCreate">The CustomerPayment to create.</param>
        /// <returns>The created CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> CreateAsync(CustomerPayment customerPaymentToCreate);        /// <summary>
        /// Creates the specified CustomerPayment using PUT.
        /// </summary>
        /// <param name="customerPaymentToCreate">The CustomerPayment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> CreateAsync(CustomerPayment customerPaymentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CustomerPayment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CustomerPayment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CustomerPayment.
        /// </summary>
        /// <returns>The CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> GetAsync();

        /// <summary>
        /// Gets the specified CustomerPayment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CustomerPayment using PATCH.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment to update.</param>
        /// <returns>The updated CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> UpdateAsync(CustomerPayment customerPaymentToUpdate);

        /// <summary>
        /// Updates the specified CustomerPayment using PATCH.
        /// </summary>
        /// <param name="customerPaymentToUpdate">The CustomerPayment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> UpdateAsync(CustomerPayment customerPaymentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Expand(Expression<Func<CustomerPayment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICustomerPaymentRequest Select(Expression<Func<CustomerPayment, object>> selectExpression);

    }
}
