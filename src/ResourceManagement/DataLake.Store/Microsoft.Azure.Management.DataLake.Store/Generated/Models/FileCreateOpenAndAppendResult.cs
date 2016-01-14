// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The response recieved after the BeginOpen, BeginCreate and BeginAppend
    /// requests.
    /// </summary>
    public partial class FileCreateOpenAndAppendResult
    {
        /// <summary>
        /// Initializes a new instance of the FileCreateOpenAndAppendResult
        /// class.
        /// </summary>
        public FileCreateOpenAndAppendResult() { }

        /// <summary>
        /// Initializes a new instance of the FileCreateOpenAndAppendResult
        /// class.
        /// </summary>
        public FileCreateOpenAndAppendResult(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// Gets or sets the redirect URI location with any necessary
        /// parameters
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
