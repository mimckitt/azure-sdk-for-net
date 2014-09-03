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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Affinity Groups operation response.
    /// </summary>
    public partial class AffinityGroupListResponse : OperationResponse, IEnumerable<AffinityGroupListResponse.AffinityGroup>
    {
        private IList<AffinityGroupListResponse.AffinityGroup> _affinityGroups;
        
        /// <summary>
        /// Optional. The affinity groups associated with the specified
        /// subscription.
        /// </summary>
        public IList<AffinityGroupListResponse.AffinityGroup> AffinityGroups
        {
            get
            {
                if (this._affinityGroups == null)
                {
                    this._affinityGroups = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.Models.AffinityGroupListResponse.AffinityGroup>();
                }
                return this._affinityGroups;
            }
            set { this._affinityGroups = value; }
        }
        
        /// <summary>
        /// Optional. The affinity groups associated with the specified
        /// subscription.
        /// </summary>
        public IList<AffinityGroupListResponse.AffinityGroup> AffinityGroupsValue
        {
            get { return this._affinityGroups; }
            set { this._affinityGroups = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AffinityGroupListResponse class.
        /// </summary>
        public AffinityGroupListResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of AffinityGroups.
        /// </summary>
        public IEnumerator<AffinityGroupListResponse.AffinityGroup> GetEnumerator()
        {
            return this.AffinityGroupsValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of AffinityGroups.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An affinity group associated with the specified subscription.
        /// </summary>
        public partial class AffinityGroup
        {
            private IList<string> _capabilities;
            
            /// <summary>
            /// Optional. Indicates if the affinity group is able to perform
            /// virtual machine-related operations. If so, the string
            /// PersistentVMRole will be returned by this element. Otherwise,
            /// this element will not be present.
            /// </summary>
            public IList<string> Capabilities
            {
                get
                {
                    if (this._capabilities == null)
                    {
                        this._capabilities = new System.Collections.Generic.List<string>();
                    }
                    return this._capabilities;
                }
                set { this._capabilities = value; }
            }
            
            /// <summary>
            /// Optional. Indicates if the affinity group is able to perform
            /// virtual machine-related operations. If so, the string
            /// PersistentVMRole will be returned by this element. Otherwise,
            /// this element will not be present.
            /// </summary>
            public IList<string> CapabilitiesValue
            {
                get { return this._capabilities; }
                set { this._capabilities = value; }
            }
            
            private ComputeCapabilities _computeCapabilities;
            
            /// <summary>
            /// Optional. The compute capabilities in this affinity group.
            /// </summary>
            public ComputeCapabilities ComputeCapabilities
            {
                get { return this._computeCapabilities; }
                set { this._computeCapabilities = value; }
            }
            
            private System.DateTime? _createdTime;
            
            /// <summary>
            /// Optional. The time that the affinity group was created.
            /// </summary>
            public System.DateTime? CreatedTime
            {
                get { return this._createdTime; }
                set { this._createdTime = value; }
            }
            
            private string _description;
            
            /// <summary>
            /// Optional. The user-supplied description for this affinity group.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. The user-supplied label for the affinity group,
            /// returned as a base-64-encoded string.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _location;
            
            /// <summary>
            /// Optional. The user-specified data center that this affinity
            /// groups is located in.
            /// </summary>
            public string Location
            {
                get { return this._location; }
                set { this._location = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The user-supplied name for the affinity group.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the AffinityGroup class.
            /// </summary>
            public AffinityGroup()
            {
            }
        }
    }
}
