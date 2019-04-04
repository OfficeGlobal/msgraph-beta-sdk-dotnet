// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsPhone81TrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IWindowsPhone81TrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <returns>The WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified WindowsPhone81TrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToCreate">The WindowsPhone81TrustedRootCertificate to create.</param>
        /// <returns>The created WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> CreateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToCreate);        /// <summary>
        /// Creates the specified WindowsPhone81TrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToCreate">The WindowsPhone81TrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> CreateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified WindowsPhone81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToUpdate">The WindowsPhone81TrustedRootCertificate to update.</param>
        /// <returns>The updated WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> UpdateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81TrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="windowsPhone81TrustedRootCertificateToUpdate">The WindowsPhone81TrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsPhone81TrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<WindowsPhone81TrustedRootCertificate> UpdateAsync(WindowsPhone81TrustedRootCertificate windowsPhone81TrustedRootCertificateToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81TrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81TrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81TrustedRootCertificateWithReferenceRequest Expand(Expression<Func<WindowsPhone81TrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81TrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81TrustedRootCertificateWithReferenceRequest Select(Expression<Func<WindowsPhone81TrustedRootCertificate, object>> selectExpression);

    }
}
