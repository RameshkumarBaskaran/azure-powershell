// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the properties of a supported private link resource for the Azure
    /// Cognitive Search service. For a given API version, this represents the
    /// &#39;supported&#39; groupIds when creating a shared private link resource.
    /// </summary>
    public partial class PrivateLinkResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties class.
        /// </summary>
        public PrivateLinkResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties class.
        /// </summary>

        /// <param name="groupId">The group ID of the private link resource.
        /// </param>

        /// <param name="requiredMembers">The list of required members of the private link resource.
        /// </param>

        /// <param name="requiredZoneNames">The list of required DNS zone names of the private link resource.
        /// </param>

        /// <param name="shareablePrivateLinkResourceTypes">The list of resources that are onboarded to private link service, that are
        /// supported by Azure Cognitive Search.
        /// </param>
        public PrivateLinkResourceProperties(string groupId = default(string), System.Collections.Generic.IList<string> requiredMembers = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> requiredZoneNames = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<ShareablePrivateLinkResourceType> shareablePrivateLinkResourceTypes = default(System.Collections.Generic.IList<ShareablePrivateLinkResourceType>))

        {
            this.GroupId = groupId;
            this.RequiredMembers = requiredMembers;
            this.RequiredZoneNames = requiredZoneNames;
            this.ShareablePrivateLinkResourceTypes = shareablePrivateLinkResourceTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the group ID of the private link resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "groupId")]
        public string GroupId {get; private set; }

        /// <summary>
        /// Gets the list of required members of the private link resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requiredMembers")]
        public System.Collections.Generic.IList<string> RequiredMembers {get; private set; }

        /// <summary>
        /// Gets the list of required DNS zone names of the private link resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requiredZoneNames")]
        public System.Collections.Generic.IList<string> RequiredZoneNames {get; private set; }

        /// <summary>
        /// Gets the list of resources that are onboarded to private link service, that
        /// are supported by Azure Cognitive Search.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "shareablePrivateLinkResourceTypes")]
        public System.Collections.Generic.IList<ShareablePrivateLinkResourceType> ShareablePrivateLinkResourceTypes {get; private set; }
    }
}