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
    /// Contains information about the execution of a Job Preparation task on a
    /// compute node.
    /// </summary>
    public partial class JobPreparationTaskExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationTaskExecutionInformation class.
        /// </summary>
        public JobPreparationTaskExecutionInformation() { }

        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationTaskExecutionInformation class.
        /// </summary>
        /// <param name="startTime">The time at which the task started
        /// running.</param>
        /// <param name="state">The current state of the Job Preparation task
        /// on the compute node.</param>
        /// <param name="retryCount">The number of times the task has been
        /// retried by the Batch service. Every time the task exits with a
        /// non-zero exit code, it is deemed a task failure. The Batch service
        /// will retry the task up to the limit specified by the
        /// constraints.</param>
        /// <param name="endTime">The time at which the Job Preparation task
        /// completed.</param>
        /// <param name="taskRootDirectory">The root directory of the Job
        /// Preparation task on the compute node. You can use this path to
        /// retrieve files created by the task, such as log files.</param>
        /// <param name="taskRootDirectoryUrl">The URL to the root directory of
        /// the Job Preparation task on the compute node.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the task command line.</param>
        /// <param name="schedulingError">The error encountered by the Batch
        /// service when starting the task.</param>
        /// <param name="lastRetryTime">The most recent time at which a retry
        /// of the Job Preparation task started running.</param>
        public JobPreparationTaskExecutionInformation(System.DateTime startTime, JobPreparationTaskState state, int retryCount, System.DateTime? endTime = default(System.DateTime?), string taskRootDirectory = default(string), string taskRootDirectoryUrl = default(string), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), System.DateTime? lastRetryTime = default(System.DateTime?))
        {
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
        }

        /// <summary>
        /// Gets or sets the time at which the task started running.
        /// </summary>
        /// <remarks>
        /// Note that every time the task is restarted, this value is updated.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Job Preparation task completed.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the Completed state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Job Preparation task on the
        /// compute node.
        /// </summary>
        /// <remarks>
        /// Possible values are: running – the task is currently running
        /// (including retrying). completed – the task has exited with exit
        /// code 0, or the task has exhausted its retry limit, or the Batch
        /// service was unable to start the task due to scheduling errors.
        /// Possible values include: 'running', 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public JobPreparationTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the root directory of the Job Preparation task on the
        /// compute node. You can use this path to retrieve files created by
        /// the task, such as log files.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskRootDirectory")]
        public string TaskRootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL to the root directory of the Job Preparation
        /// task on the compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskRootDirectoryUrl")]
        public string TaskRootDirectoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the task
        /// command line.
        /// </summary>
        /// <remarks>
        /// This parameter is returned only if the task is in the completed
        /// state. The exit code for a process reflects the specific convention
        /// implemented by the application developer for that process. If you
        /// use the exit code value to make decisions in your code, be sure
        /// that you know the exit code convention used by the application
        /// process. Note that the exit code may also be generated by the
        /// compute node operating system, such as when a process is forcibly
        /// terminated.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets the error encountered by the Batch service when
        /// starting the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been retried by the
        /// Batch service. Every time the task exits with a non-zero exit code,
        /// it is deemed a task failure. The Batch service will retry the task
        /// up to the limit specified by the constraints.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the Job
        /// Preparation task started running.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task was retried (i.e. retryCount
        /// is nonzero). If present, this is typically the same as startTime,
        /// but may be different if the task has been restarted for reasons
        /// other than retry; for example, if the compute node was rebooted
        /// during a retry, then the startTime is updated but the lastRetryTime
        /// is not.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRetryTime")]
        public System.DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}
