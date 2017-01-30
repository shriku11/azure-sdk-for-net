// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// PoolOperations operations.
    /// </summary>
    public partial interface IPoolOperations
    {
        /// <summary>
        /// Lists the usage metrics, aggregated by pool across individual time
        /// intervals, for the specified account.
        /// </summary>
        /// <remarks>
        /// If you do not specify a $filter clause including a poolId, the
        /// response includes all pools that existed in the account in the time
        /// range of the returned aggregation intervals.
        /// </remarks>
        /// <param name='poolListPoolUsageMetricsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<PoolUsageMetrics>,PoolListPoolUsageMetricsHeaders>> ListPoolUsageMetricsWithHttpMessagesAsync(PoolListPoolUsageMetricsOptions poolListPoolUsageMetricsOptions = default(PoolListPoolUsageMetricsOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets lifetime summary statistics for all of the pools in the
        /// specified account.
        /// </summary>
        /// <remarks>
        /// Statistics are aggregated across all pools that have ever existed
        /// in the account, from account creation to the last update time of
        /// the statistics.
        /// </remarks>
        /// <param name='poolGetAllPoolsLifetimeStatisticsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<PoolStatistics,PoolGetAllPoolsLifetimeStatisticsHeaders>> GetAllPoolsLifetimeStatisticsWithHttpMessagesAsync(PoolGetAllPoolsLifetimeStatisticsOptions poolGetAllPoolsLifetimeStatisticsOptions = default(PoolGetAllPoolsLifetimeStatisticsOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Adds a pool to the specified account.
        /// </summary>
        /// <remarks>
        /// When naming pools, avoid including sensitive information such as
        /// user names or secret project names. This information may appear in
        /// telemetry logs accessible to Microsoft Support engineers.
        /// </remarks>
        /// <param name='pool'>
        /// The pool to be added.
        /// </param>
        /// <param name='poolAddOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolAddHeaders>> AddWithHttpMessagesAsync(PoolAddParameter pool, PoolAddOptions poolAddOptions = default(PoolAddOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the pools in the specified account.
        /// </summary>
        /// <param name='poolListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudPool>,PoolListHeaders>> ListWithHttpMessagesAsync(PoolListOptions poolListOptions = default(PoolListOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a pool from the specified account.
        /// </summary>
        /// <remarks>
        /// When you request that a pool be deleted, the following actions
        /// occur: the pool state is set to deleting; any ongoing resize
        /// operation on the pool are stopped; the Batch service starts
        /// resizing the pool to zero nodes; any tasks running on existing
        /// nodes are terminated and requeued (as if a resize pool operation
        /// had been requested with the default requeue option); finally, the
        /// pool is removed from the system. Because running tasks are
        /// requeued, the user can rerun these tasks by updating their job to
        /// target a different pool. The tasks can then run on the new pool. If
        /// you want to override the requeue behavior, then you should call
        /// resize pool explicitly to shrink the pool to zero size before
        /// deleting the pool. If you call an Update, Patch or Delete API on a
        /// pool in the deleting state, it will fail with HTTP status code 409
        /// with error code PoolBeingDeleted.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool to delete.
        /// </param>
        /// <param name='poolDeleteOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolDeleteHeaders>> DeleteWithHttpMessagesAsync(string poolId, PoolDeleteOptions poolDeleteOptions = default(PoolDeleteOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets basic properties of a pool.
        /// </summary>
        /// <param name='poolId'>
        /// The ID of the pool to get.
        /// </param>
        /// <param name='poolExistsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<bool,PoolExistsHeaders>> ExistsWithHttpMessagesAsync(string poolId, PoolExistsOptions poolExistsOptions = default(PoolExistsOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets information about the specified pool.
        /// </summary>
        /// <param name='poolId'>
        /// The ID of the pool to get.
        /// </param>
        /// <param name='poolGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<CloudPool,PoolGetHeaders>> GetWithHttpMessagesAsync(string poolId, PoolGetOptions poolGetOptions = default(PoolGetOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the properties of the specified pool.
        /// </summary>
        /// <remarks>
        /// This only replaces the pool properties specified in the request.
        /// For example, if the pool has a start task associated with it, and a
        /// request does not specify a start task element, then the pool keeps
        /// the existing start task.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool to update.
        /// </param>
        /// <param name='poolPatchParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='poolPatchOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolPatchHeaders>> PatchWithHttpMessagesAsync(string poolId, PoolPatchParameter poolPatchParameter, PoolPatchOptions poolPatchOptions = default(PoolPatchOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Disables automatic scaling for a pool.
        /// </summary>
        /// <param name='poolId'>
        /// The ID of the pool on which to disable automatic scaling.
        /// </param>
        /// <param name='poolDisableAutoScaleOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolDisableAutoScaleHeaders>> DisableAutoScaleWithHttpMessagesAsync(string poolId, PoolDisableAutoScaleOptions poolDisableAutoScaleOptions = default(PoolDisableAutoScaleOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Enables automatic scaling for a pool.
        /// </summary>
        /// <remarks>
        /// You cannot enable automatic scaling on a pool if a resize operation
        /// is in progress on the pool. If automatic scaling of the pool is
        /// currently disabled, you must specify a valid autoscale formula as
        /// part of the request. If automatic scaling of the pool is already
        /// enabled, you may specify a new autoscale formula and/or a new
        /// evaluation interval. You cannot call this API for the same pool
        /// more than once every 30 seconds.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool on which to enable automatic scaling.
        /// </param>
        /// <param name='poolEnableAutoScaleParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='poolEnableAutoScaleOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolEnableAutoScaleHeaders>> EnableAutoScaleWithHttpMessagesAsync(string poolId, PoolEnableAutoScaleParameter poolEnableAutoScaleParameter, PoolEnableAutoScaleOptions poolEnableAutoScaleOptions = default(PoolEnableAutoScaleOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the result of evaluating an automatic scaling formula on the
        /// pool.
        /// </summary>
        /// <remarks>
        /// This API is primarily for validating an autoscale formula, as it
        /// simply returns the result without applying the formula to the pool.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool on which to evaluate the automatic scaling
        /// formula.
        /// </param>
        /// <param name='autoScaleFormula'>
        /// The formula for the desired number of compute nodes in the pool.
        /// The formula is validated and its results calculated, but it is not
        /// applied to the pool. To apply the formula to the pool, 'Enable
        /// automatic scaling on a pool'. For more information about specifying
        /// this formula, see Automatically scale compute nodes in an Azure
        /// Batch pool
        /// (https://azure.microsoft.com/en-us/documentation/articles/batch-automatic-scaling).
        /// </param>
        /// <param name='poolEvaluateAutoScaleOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AutoScaleRun,PoolEvaluateAutoScaleHeaders>> EvaluateAutoScaleWithHttpMessagesAsync(string poolId, string autoScaleFormula, PoolEvaluateAutoScaleOptions poolEvaluateAutoScaleOptions = default(PoolEvaluateAutoScaleOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Changes the number of compute nodes that are assigned to a pool.
        /// </summary>
        /// <remarks>
        /// You can only resize a pool when its allocation state is steady. If
        /// the pool is already resizing, the request fails with status code
        /// 409. When you resize a pool, the pool's allocation state changes
        /// from steady to resizing. You cannot resize pools which are
        /// configured for automatic scaling. If you try to do this, the Batch
        /// service returns an error 409. If you resize a pool downwards, the
        /// Batch service chooses which nodes to remove. To remove specific
        /// nodes, use the pool remove nodes API instead.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool to resize.
        /// </param>
        /// <param name='poolResizeParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='poolResizeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolResizeHeaders>> ResizeWithHttpMessagesAsync(string poolId, PoolResizeParameter poolResizeParameter, PoolResizeOptions poolResizeOptions = default(PoolResizeOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Stops an ongoing resize operation on the pool.
        /// </summary>
        /// <remarks>
        /// This does not restore the pool to its previous state before the
        /// resize operation: it only stops any further changes being made, and
        /// the pool maintains its current state. A resize operation need not
        /// be an explicit resize pool request; this API can also be used to
        /// halt the initial sizing of the pool when it is created.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool whose resizing you want to stop.
        /// </param>
        /// <param name='poolStopResizeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolStopResizeHeaders>> StopResizeWithHttpMessagesAsync(string poolId, PoolStopResizeOptions poolStopResizeOptions = default(PoolStopResizeOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the properties of the specified pool.
        /// </summary>
        /// <remarks>
        /// This fully replaces all the updateable properties of the pool. For
        /// example, if the pool has a start task associated with it and if
        /// start task is not specified with this request, then the Batch
        /// service will remove the existing start task.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool to update.
        /// </param>
        /// <param name='poolUpdatePropertiesParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='poolUpdatePropertiesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolUpdatePropertiesHeaders>> UpdatePropertiesWithHttpMessagesAsync(string poolId, PoolUpdatePropertiesParameter poolUpdatePropertiesParameter, PoolUpdatePropertiesOptions poolUpdatePropertiesOptions = default(PoolUpdatePropertiesOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upgrades the operating system of the specified pool.
        /// </summary>
        /// <remarks>
        /// During an upgrade, the Batch service upgrades each compute node in
        /// the pool. When a compute node is chosen for upgrade, any tasks
        /// running on that node are removed from the node and returned to the
        /// queue to be rerun later (or on a different compute node). The node
        /// will be unavailable until the upgrade is complete. This operation
        /// results in temporarily reduced pool capacity as nodes are taken out
        /// of service to be upgraded. Although the Batch service tries to
        /// avoid upgrading all compute nodes at the same time, it does not
        /// guarantee to do this (particularly on small pools); therefore, the
        /// pool may be temporarily unavailable to run tasks. When this
        /// operation runs, the pool state changes to upgrading. When all
        /// compute nodes have finished upgrading, the pool state returns to
        /// active.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool to upgrade.
        /// </param>
        /// <param name='targetOSVersion'>
        /// The Azure Guest OS version to be installed on the virtual machines
        /// in the pool.
        /// </param>
        /// <param name='poolUpgradeOSOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolUpgradeOSHeaders>> UpgradeOSWithHttpMessagesAsync(string poolId, string targetOSVersion, PoolUpgradeOSOptions poolUpgradeOSOptions = default(PoolUpgradeOSOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Removes compute nodes from the specified pool.
        /// </summary>
        /// <remarks>
        /// This operation can only run when the allocation state of the pool
        /// is steady. When this operation runs, the allocation state changes
        /// from steady to resizing.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool from which you want to remove nodes.
        /// </param>
        /// <param name='nodeRemoveParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='poolRemoveNodesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<PoolRemoveNodesHeaders>> RemoveNodesWithHttpMessagesAsync(string poolId, NodeRemoveParameter nodeRemoveParameter, PoolRemoveNodesOptions poolRemoveNodesOptions = default(PoolRemoveNodesOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists the usage metrics, aggregated by pool across individual time
        /// intervals, for the specified account.
        /// </summary>
        /// <remarks>
        /// If you do not specify a $filter clause including a poolId, the
        /// response includes all pools that existed in the account in the time
        /// range of the returned aggregation intervals.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='poolListPoolUsageMetricsNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<PoolUsageMetrics>,PoolListPoolUsageMetricsHeaders>> ListPoolUsageMetricsNextWithHttpMessagesAsync(string nextPageLink, PoolListPoolUsageMetricsNextOptions poolListPoolUsageMetricsNextOptions = default(PoolListPoolUsageMetricsNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the pools in the specified account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='poolListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<CloudPool>,PoolListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, PoolListNextOptions poolListNextOptions = default(PoolListNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
