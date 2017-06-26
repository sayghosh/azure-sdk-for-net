// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the start runbook operation.
    /// </summary>
    public partial class RunbookDraftUpdateParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the runbook name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _stream;
        
        /// <summary>
        /// Required. Gets or sets the content of the runbook version.
        /// </summary>
        public string Stream
        {
            get { return this._stream; }
            set { this._stream = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookDraftUpdateParameters
        /// class.
        /// </summary>
        public RunbookDraftUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookDraftUpdateParameters
        /// class with required arguments.
        /// </summary>
        public RunbookDraftUpdateParameters(string name, string stream)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            this.Name = name;
            this.Stream = stream;
        }
    }
}