// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ApplicationOperationsExtensions
    {
            /// <summary>
            /// Create a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            public static Application Create(this IApplicationOperations operations, ApplicationCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationOperations)s).CreateAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> CreateAsync( this IApplicationOperations operations, ApplicationCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Delete an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static void Delete(this IApplicationOperations operations, string applicationObjectId)
            {
                Task.Factory.StartNew(s => ((IApplicationOperations)s).DeleteAsync(applicationObjectId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IApplicationOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get an application by object Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static Application Get(this IApplicationOperations operations, string applicationObjectId)
            {
                return Task.Factory.StartNew(s => ((IApplicationOperations)s).GetAsync(applicationObjectId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an application by object Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> GetAsync( this IApplicationOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Update existing application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            public static void Update(this IApplicationOperations operations, string applicationObjectId, ApplicationCreateParameters parameters)
            {
                Task.Factory.StartNew(s => ((IApplicationOperations)s).UpdateAsync(applicationObjectId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update existing application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync( this IApplicationOperations operations, string applicationObjectId, ApplicationCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpdateWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
