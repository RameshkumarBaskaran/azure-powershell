// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Extensions;

    /// <summary>Definition of resource.</summary>
    public partial class TrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResource,
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.Resource();

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.TrackedResourceTags()); set => this._tag = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Origin(Microsoft.Azure.PowerShell.Cmdlets.Relay.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="TrackedResource" /> instance.</summary>
        public TrackedResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Definition of resource.
    public partial interface ITrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResource
    {
        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceTags Tag { get; set; }

    }
    /// Definition of resource.
    internal partial interface ITrackedResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IResourceInternal
    {
        /// <summary>Resource location.</summary>
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.ITrackedResourceTags Tag { get; set; }

    }
}