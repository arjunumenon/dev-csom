using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace console_HelloWorld.Helpers
{
    /// <summary>
    /// Helper for authenticating using Azure AD
    /// </summary>
    public class AuthenticateAzureAD
    {
        public ClientContext getClientContextAzureAddin(string siteUrl, 
            string appId, string spDomain,string certPath, string certPassword)
        {
            using (var cc = new AuthenticationManager().GetAzureADAppOnlyAuthenticatedContext(siteUrl,
                appId, spDomain,
                certPath, certPassword))
            {
                cc.Load(cc.Web, p => p.Title);
                cc.ExecuteQuery();

                return cc;
            };
        }
    }
}
