// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Secret definition.
/// </summary>
public partial class ContainerAppWritableSecret : ProvisionableConstruct
{
    /// <summary>
    /// Secret Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Secret Value.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Resource ID of a managed identity to authenticate with Azure Key Vault,
    /// or System to use a system-assigned identity.
    /// </summary>
    public BicepValue<string> Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); _identity!.Assign(value); }
    }
    private BicepValue<string>? _identity;

    /// <summary>
    /// Azure Key Vault URL pointing to the secret referenced by the container
    /// app.
    /// </summary>
    public BicepValue<Uri> KeyVaultUri 
    {
        get { Initialize(); return _keyVaultUri!; }
        set { Initialize(); _keyVaultUri!.Assign(value); }
    }
    private BicepValue<Uri>? _keyVaultUri;

    /// <summary>
    /// Creates a new ContainerAppWritableSecret.
    /// </summary>
    public ContainerAppWritableSecret()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppWritableSecret.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _value = DefineProperty<string>("Value", ["value"]);
        _identity = DefineProperty<string>("Identity", ["identity"]);
        _keyVaultUri = DefineProperty<Uri>("KeyVaultUri", ["keyVaultUrl"]);
    }
}
