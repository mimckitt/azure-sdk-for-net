// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the job context type.
    /// </summary>
    public partial class JobContext
    {
        private string _accountId;
        
        /// <summary>
        /// Optional. The account ID of the job context.
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The job context ID.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private IList<JobParameter> _jobParameters;
        
        /// <summary>
        /// Optional. A list of job parameters.
        /// </summary>
        public IList<JobParameter> JobParameters
        {
            get
            {
                if (this._jobParameters == null)
                {
                    this._jobParameters = new System.Collections.Generic.List<Microsoft.Azure.Management.Automation.Models.JobParameter>();
                }
                return this._jobParameters;
            }
            set { this._jobParameters = value; }
        }
        
        /// <summary>
        /// Optional. A list of job parameters.
        /// </summary>
        public IList<JobParameter> JobParametersValue
        {
            get { return this._jobParameters; }
            set { this._jobParameters = value; }
        }
        
        private RunbookVersion _runbookVersion;
        
        /// <summary>
        /// Optional. The runbook version of the job context.
        /// </summary>
        public RunbookVersion RunbookVersion
        {
            get { return this._runbookVersion; }
            set { this._runbookVersion = value; }
        }
        
        private string _runbookVersionId;
        
        /// <summary>
        /// Optional. The runbook version ID of the job context
        /// </summary>
        public string RunbookVersionId
        {
            get { return this._runbookVersionId; }
            set { this._runbookVersionId = value; }
        }
        
        private Schedule _schedule;
        
        /// <summary>
        /// Optional. The schedule of the job context.
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }
        
        private string _scheduleId;
        
        /// <summary>
        /// Optional. The schedule ID of the job context.
        /// </summary>
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobContext class.
        /// </summary>
        public JobContext()
        {
        }
    }
}
