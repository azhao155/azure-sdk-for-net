// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Active Directory object information
    /// </summary>
    public partial class AADObject
    {
        /// <summary>
        /// Initializes a new instance of the AADObject class.
        /// </summary>
        public AADObject() { }

        /// <summary>
        /// Initializes a new instance of the AADObject class.
        /// </summary>
        public AADObject(string objectId = default(string), string objectType = default(string), string displayName = default(string), string userPrincipalName = default(string), string mail = default(string), bool? mailEnabled = default(bool?), bool? securityEnabled = default(bool?), string signInName = default(string), IList<string> servicePrincipalNames = default(IList<string>))
        {
            ObjectId = objectId;
            ObjectType = objectType;
            DisplayName = displayName;
            UserPrincipalName = userPrincipalName;
            Mail = mail;
            MailEnabled = mailEnabled;
            SecurityEnabled = securityEnabled;
            SignInName = signInName;
            ServicePrincipalNames = servicePrincipalNames;
        }

        /// <summary>
        /// Gets or sets object Id
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets object type
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets object display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets principal name
        /// </summary>
        [JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets mail
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets MailEnabled field
        /// </summary>
        [JsonProperty(PropertyName = "mailEnabled")]
        public bool? MailEnabled { get; set; }

        /// <summary>
        /// Gets or sets SecurityEnabled field
        /// </summary>
        [JsonProperty(PropertyName = "securityEnabled")]
        public bool? SecurityEnabled { get; set; }

        /// <summary>
        /// Gets or sets signIn name
        /// </summary>
        [JsonProperty(PropertyName = "signInName")]
        public string SignInName { get; set; }

        /// <summary>
        /// Gets or sets the list of service principal names.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalNames")]
        public IList<string> ServicePrincipalNames { get; set; }

    }
}