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
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.HDInsight.Job.Models;

namespace Microsoft.Azure.Management.HDInsight.Job.Models
{
    /// <summary>
    /// The List Job operation response.
    /// </summary>
    public partial class JobListResponse : AzureOperationResponse, IEnumerable<JobListJsonObject>
    {
        private IList<JobListJsonObject> _jobList;
        
        /// <summary>
        /// Optional. Gets or sets the job list result object recieved from the
        /// HDInsight cluster.
        /// </summary>
        public IList<JobListJsonObject> JobList
        {
            get { return this._jobList; }
            set { this._jobList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobListResponse class.
        /// </summary>
        public JobListResponse()
        {
            this.JobList = new LazyList<JobListJsonObject>();
        }
        
        /// <summary>
        /// Gets the sequence of JobList.
        /// </summary>
        public IEnumerator<JobListJsonObject> GetEnumerator()
        {
            return this.JobList.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of JobList.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}