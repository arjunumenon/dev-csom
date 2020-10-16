using console_HelloWorld.Helpers;
using Microsoft.Identity.Client;
using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.Online.SharePoint.TenantManagement;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_HelloWorld
{
    class Program
    {
        public static IPublicClientApplication publicClientApp;
        private enum _Tenant
        {
            AUMOnline = 0,
            AUM365 = 1
        }

        private class AuthProperties
        {
            public string SiteURL;
            public string AppId;
            public string domainDetails;
            public string certPath;
            public string certPass;

            public AuthProperties(_Tenant tenant)
            {
                switch(tenant)
                {
                    case _Tenant.AUMOnline:
                        {
                            SiteURL = "https://aumonline-admin.sharepoint.com";
                            AppId = "497d0d82-cb8e-4798-9525-b8970751c3bf";
                            domainDetails = "aumonline.onmicrosoft.com";
                            certPath = @"C:\Arjun\Git\CSOM\Azure Add-in\A-UMCSOM.pfx";
                            certPass = "P@ssw0rd4aum";
                            break;
                        }
                    case _Tenant.AUM365:
                        {
                            SiteURL = "https://aum365-admin.sharepoint.com";
                            AppId = "d725c3bd-4977-4dba-8429-454cb2ad7b72";
                            domainDetails = "aum365.onmicrosoft.com";
                            certPath = @"C:\Arjun\Git\CSOM\Azure Add-in\AUM365-CSOM.pfx";
                            certPass = "P@ssw0rd";
                            break;
                        }
                }                
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var TargetsiteURL = args[0];

            AuthProperties authProps = new AuthProperties(_Tenant.AUMOnline);

            authProps.SiteURL = "https://aumonline.sharepoint.com/sites/M365CLI";

            ClientContext ctx = authenticateUsingAzureAddin(authProps);

            //Get Sharing information
            //string sharingInfosite = "https://aum365.sharepoint.com/sites/M365CLI";
            //getSharingSettings(ctx, sharingInfosite,true);

            //Get File Sharing Info
            getFileSharingInfo(ctx);
        }

        private static async Task consumeSPOwithAuthToken(string targetSiteURL)
        {
            var spoTenant = targetSiteURL.Substring(0, targetSiteURL.IndexOf('/', 8));

            publicClientApp = PublicClientApplicationBuilder.Create("CLIENTID").
                WithDefaultRedirectUri().Build();

            var _scopes = new string[] { $"{spoTenant}/AllSites.Read" };

            var authResult = await publicClientApp.AcquireTokenInteractive(_scopes)
                .ExecuteAsync();

            //Get Acces Token
            Console.WriteLine("Access Token for Graph API");
            Console.WriteLine(authResult.AccessToken);
        }

        private static ClientContext authenticateUsingAzureAddin(AuthProperties authProperties)
        {
            AuthenticateAzureAD authAzureAD = new AuthenticateAzureAD();
            ClientContext ctxaum = authAzureAD.getClientContextAzureAddin(authProperties.SiteURL,
                authProperties.AppId, authProperties.domainDetails, authProperties.certPath, 
                authProperties.certPass);

            return ctxaum;
        }


        private static void getSharingSettings(ClientContext ctsTenant,string strURL,bool getSiteInfo)
        {
            // Get site collection
            Tenant tenant = new Tenant(ctsTenant);
            SiteProperties siteProp = tenant.GetSitePropertiesByUrl(strURL, true);

            if (getSiteInfo)
            {
                ctsTenant.Load(siteProp);
                ctsTenant.ExecuteQuery();

                SharingCapabilities CurrentSharingSettings;
                CurrentSharingSettings = siteProp.SharingCapability;

                if (CurrentSharingSettings.Equals(SharingCapabilities.Disabled))
                {
                    siteProp.SharingCapability = SharingCapabilities.ExternalUserAndGuestSharing;
                }
                else
                {
                    siteProp.SharingCapability = SharingCapabilities.Disabled;
                }
            }
            else
            {
                siteProp.SharingCapability = SharingCapabilities.Disabled;
            }            

            // Update based on applied setting
            siteProp.Update();
            ctsTenant.ExecuteQuery();
        }

        private static void getFileSharingInfo(ClientContext ctsSite)
        {
            fileSharingInfo FileSharingInfo = new fileSharingInfo();

            string strDocumentURL = "https://aumonline.sharepoint.com/sites/M365CLI/Shared%20Documents/Sharing%20Central.docx";

            FileSharingInfo.getFileSharingInfo(ctsSite, strDocumentURL);

        }
       

    }
}
