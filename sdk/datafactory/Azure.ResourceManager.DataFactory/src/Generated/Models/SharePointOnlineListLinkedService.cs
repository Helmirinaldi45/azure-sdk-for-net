// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SharePoint Online List linked service. </summary>
    public partial class SharePointOnlineListLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SharePointOnlineListLinkedService"/>. </summary>
        /// <param name="siteUri"> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </param>
        /// <param name="tenantId"> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteUri"/>, <paramref name="tenantId"/>, <paramref name="servicePrincipalId"/> or <paramref name="servicePrincipalKey"/> is null. </exception>
        public SharePointOnlineListLinkedService(DataFactoryElement<string> siteUri, DataFactoryElement<string> tenantId, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey)
        {
            Argument.AssertNotNull(siteUri, nameof(siteUri));
            Argument.AssertNotNull(tenantId, nameof(tenantId));
            Argument.AssertNotNull(servicePrincipalId, nameof(servicePrincipalId));
            Argument.AssertNotNull(servicePrincipalKey, nameof(servicePrincipalKey));

            SiteUri = siteUri;
            TenantId = tenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            LinkedServiceType = "SharePointOnlineList";
        }

        /// <summary> Initializes a new instance of <see cref="SharePointOnlineListLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="siteUri"> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </param>
        /// <param name="tenantId"> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SharePointOnlineListLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> siteUri, DataFactoryElement<string> tenantId, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            SiteUri = siteUri;
            TenantId = tenantId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SharePointOnlineList";
        }

        /// <summary> Initializes a new instance of <see cref="SharePointOnlineListLinkedService"/> for deserialization. </summary>
        internal SharePointOnlineListLinkedService()
        {
        }

        /// <summary> The URL of the SharePoint Online site. For example, https://contoso.sharepoint.com/sites/siteName. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SiteUri { get; set; }
        /// <summary> The tenant ID under which your application resides. You can find it from Azure portal Active Directory overview page. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TenantId { get; set; }
        /// <summary> The application (client) ID of your application registered in Azure Active Directory. Make sure to grant SharePoint site permission to this application. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The client secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
