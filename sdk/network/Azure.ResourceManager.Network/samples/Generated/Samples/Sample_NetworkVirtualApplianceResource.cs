// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceResource
    {
        // Delete NetworkVirtualAppliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceDelete.json
            // this example is just showing the usage of "NetworkVirtualAppliances_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // invoke the operation
            await networkVirtualAppliance.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get NetworkVirtualAppliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceGet.json
            // this example is just showing the usage of "NetworkVirtualAppliances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // invoke the operation
            NetworkVirtualApplianceResource result = await networkVirtualAppliance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update NetworkVirtualAppliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceUpdateTags.json
            // this example is just showing the usage of "NetworkVirtualAppliances_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            NetworkVirtualApplianceResource result = await networkVirtualAppliance.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all Network Virtual Appliances for a given subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkVirtualAppliances_ListAllNetworkVirtualAppliancesForAGivenSubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkVirtualApplianceListBySubscription.json
            // this example is just showing the usage of "NetworkVirtualAppliances_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkVirtualApplianceResource item in subscriptionResource.GetNetworkVirtualAppliancesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create Network Virtual Appliance Inbound Security Rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateInboundSecurityRule_CreateNetworkVirtualApplianceInboundSecurityRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/InboundSecurityRulePut.json
            // this example is just showing the usage of "InboundSecurityRule_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // invoke the operation
            string ruleCollectionName = "rule1";
            InboundSecurityRule inboundSecurityRule = new InboundSecurityRule()
            {
                Rules =
{
new InboundSecurityRules()
{
Protocol = InboundSecurityRulesProtocol.Tcp,
SourceAddressPrefix = "50.20.121.5/32",
DestinationPortRange = 22,
}
},
            };
            ArmOperation<InboundSecurityRule> lro = await networkVirtualAppliance.CreateOrUpdateInboundSecurityRuleAsync(WaitUntil.Completed, ruleCollectionName, inboundSecurityRule);
            InboundSecurityRule result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
