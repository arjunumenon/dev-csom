using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace WindowsFormsApp1.Helpers
{
    public class AuthenticationHelper
    {
        /// <summary>
        /// Authenticaiton using Username and Password
        /// </summary>
        /// <param name="webUrl">Web URL</param>
        /// <param name="userName">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public ClientContext fngetAuthenticationUNPWD(string webUrl,string userName, string password)
        {

            var securepassword = new SecureString();
            foreach (char c in password)
            {
                securepassword.AppendChar(c);
            }

            using (var context = new ClientContext(webUrl))
            {
                context.Credentials = new SharePointOnlineCredentials(userName, securepassword);
                context.Load(context.Web, web => web.Title);
                context.ExecuteQuery();
                Console.WriteLine("Your site title is: " + context.Web.Title);

                return context;
            }
        }
    }
}
