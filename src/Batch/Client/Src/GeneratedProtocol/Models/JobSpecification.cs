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

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies details of the jobs to be created on a schedule.
    /// </summary>
    public partial class JobSpecification
    {
        /// <summary>
        /// Initializes a new instance of the JobSpecification class.
        /// </summary>
        public JobSpecification() { }

        /// <summary>
        /// Initializes a new instance of the JobSpecification class.
        /// </summary>
        /// <param name="poolInfo">The pool on which the Batch service runs the
        /// tasks of jobs created under this schedule.</param>
        /// <param name="priority">The priority of jobs created under this
        /// schedule.</param>
        /// <param name="displayName">The display name for jobs created under
        /// this schedule.</param>
        /// <param name="usesTaskDependencies">The flag that determines if this
        /// job will use tasks with dependencies.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in a job created under this schedule are
        /// in the completed state.</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any task fails in a job created under this schedule. A
        /// task is considered to have failed if it completes with a non-zero
        /// exit code and has exhausted its retry count, or if it had a
        /// scheduling error.</param>
        /// <param name="constraints">The execution constraints for jobs
        /// created under this schedule.</param>
        /// <param name="jobManagerTask">The details of a Job Manager task to
        /// be launched when a job is started under this schedule.</param>
        /// <param name="jobPreparationTask">The Job Preparation task for jobs
        /// created under this schedule.</param>
        /// <param name="jobReleaseTask">The Job Release task for jobs created
        /// under this schedule.</param>
        /// <param name="commonEnvironmentSettings">A list of common
        /// environment variable settings. These environment variables are set
        /// for all tasks in jobs created under this schedule (including the
        /// Job Manager, Job Preparation and Job Release tasks).</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// each job created under this schedule as metadata.</param>
        public JobSpecification(PoolInformation poolInfo, int? priority = default(int?), string displayName = default(string), bool? usesTaskDependencies = default(bool?), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), System.Collections.Generic.IList<EnvironmentSetting> commonEnvironmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>))
        {
            Priority = priority;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the priority of jobs created under this schedule.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. The default
        /// value is 0. This priority is used as the default for all jobs under
        /// the job schedule. You can update a job's priority after it has been
        /// created using by using the update job API.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the display name for jobs created under this schedule.
        /// </summary>
        /// <remarks>
        /// The name need not be unique and can contain any Unicode characters
        /// up to a maximum length of 1024.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the flag that determines if this job will use tasks
        /// with dependencies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in a job created under this schedule are in the completed
        /// state.
        /// </summary>
        /// <remarks>
        /// Note that if a job contains no tasks, then all tasks are considered
        /// complete. This option is therefore most commonly used with a job
        /// manager task; if you want to use automatic job termination without
        /// a job manager, you should initially set onAllTasksComplete to
        /// noaction and update the job properties to set onAllTasksComplete to
        /// terminatejob once you have finished adding tasks. The default is
        /// noaction. Possible values include: 'noAction', 'terminateJob'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any task
        /// fails in a job created under this schedule. A task is considered to
        /// have failed if it completes with a non-zero exit code and has
        /// exhausted its retry count, or if it had a scheduling error.
        /// </summary>
        /// <remarks>
        /// The default is noaction. Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for jobs created under this
        /// schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the details of a Job Manager task to be launched when
        /// a job is started under this schedule.
        /// </summary>
        /// <remarks>
        /// If the job does not specify a Job Manager task, the user must
        /// explicitly add tasks to the job using the Task API. If the job does
        /// specify a Job Manager task, the Batch service creates the Job
        /// Manager task when the job is created, and will try to schedule the
        /// Job Manager task before scheduling other tasks in the job.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task for jobs created under this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// If a job has a Job Preparation task, the Batch service will run the
        /// Job Preparation task on a compute node before starting any tasks of
        /// that job on that compute node.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task for jobs created under this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// The primary purpose of the Job Release task is to undo changes to
        /// compute nodes made by the Job Preparation task. Example activities
        /// include deleting local files, or shutting down services that were
        /// started as part of job preparation. A Job Release task cannot be
        /// specified without also specifying a Job Preparation task for the
        /// job. The Batch service runs the Job Release task on the compute
        /// nodes that have run the Job Preparation task.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets a list of common environment variable settings. These
        /// environment variables are set for all tasks in jobs created under
        /// this schedule (including the Job Manager, Job Preparation and Job
        /// Release tasks).
        /// </summary>
        /// <remarks>
        /// Individual tasks can override an environment setting specified here
        /// by specifying the same setting name with a different value.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the tasks of
        /// jobs created under this schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with each job
        /// created under this schedule as metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolInfo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PoolInfo");
            }
            if (this.JobManagerTask != null)
            {
                this.JobManagerTask.Validate();
            }
            if (this.JobPreparationTask != null)
            {
                this.JobPreparationTask.Validate();
            }
            if (this.JobReleaseTask != null)
            {
                this.JobReleaseTask.Validate();
            }
            if (this.CommonEnvironmentSettings != null)
            {
                foreach (var element in this.CommonEnvironmentSettings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element1 in this.Metadata)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
