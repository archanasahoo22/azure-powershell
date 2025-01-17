// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxNetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkInterfaceConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkInterfaceConfigurationInternal
    {

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Creates an new <see cref="NginxNetworkInterfaceConfiguration" /> instance.</summary>
        public NginxNetworkInterfaceConfiguration()
        {

        }
    }
    public partial interface INginxNetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    internal partial interface INginxNetworkInterfaceConfigurationInternal

    {
        string SubnetId { get; set; }

    }
}