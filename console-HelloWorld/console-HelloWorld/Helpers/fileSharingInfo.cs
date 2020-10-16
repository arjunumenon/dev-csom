using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace console_HelloWorld.Helpers
{
    public class fileSharingInfo
    {
        public void getFileSharingInfo(ClientContext ctsSiteContext,string FullDocumentURL)
        {
            ObjectSharingSettings info = Web.GetObjectSharingSettings(ctsSiteContext, FullDocumentURL, 0, true);
            ctsSiteContext.Load(info.ObjectSharingInformation);
            ctsSiteContext.Load(info);
            ctsSiteContext.ExecuteQuery();

            var objSharingInfo = info.ObjectSharingInformation;
            var links = objSharingInfo.SharingLinks;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sharing Links are given below");
            foreach (var url in info.ObjectSharingInformation.SharingLinks)
            {
                if (!string.IsNullOrEmpty(url.Url))
                    Console.WriteLine("{0}", url.Url);

            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
