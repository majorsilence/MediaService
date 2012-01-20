﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.IO;
using System.Net;


namespace LibMediaServiceCommon
{
    /// <summary>
    /// Once centrilized class for downloading items/webpages/xml/images from the Project2 server.
    /// If you want to use P2WebClient directly you must login with each instance before being able to use it.
    /// </summary>
    /// <remarks>The Downloads.UserName and Downloads.Password properties must be set before using this class.</remarks>
    public sealed class Downloads
    {
        public string IPAddress {get; set;}

        private static volatile Downloads instance;
        private static object syncRoot = new Object();

        private string headerValue = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";


        public string UserName { get; set; }
        public string Password { get; set; }


        private Downloads() 
        {
        }

        public static Downloads Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Downloads();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Download an image from a web address.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Image WebImage(string url)
        {

            if (AddressExists(url) == false)
            {
                return null;
            }

            WebClient client = new WebClient();
            client.Headers.Add("user-agent", headerValue);
            NetworkCredential cred = new NetworkCredential(this.UserName, this.Password);
            client.Credentials = cred;

            if (this.UserName.Trim() == "" || this.Password.Trim() == "")
            {
                throw new MediaServiceException("Username or password not set");
            }


            byte[] img = client.DownloadData(url);
            //Image retValue;


            using (MemoryStream ms = new MemoryStream(img, 0, img.Length)) 
            { 

                ms.Write(img, 0, img.Length); 

                return Image.FromStream(ms, true, true); 
            }
            


            // return retValue;

        }

        public string GetData(string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", headerValue);
            NetworkCredential cred = new NetworkCredential(this.UserName, this.Password);
            client.Credentials = cred;

            if (this.UserName.Trim() == "" || this.Password.Trim() == "")
            {
                throw new MediaServiceException("Username or password not set");
            }

            return client.DownloadString(url);
        }

        /// <summary>
        /// Check if an url address exists.
        /// </summary>
        /// <param name="urlAddress"></param>
        /// <returns></returns>
        /// <remarks>Keeps track of authentication using cookies.</remarks>
        public Boolean AddressExists(string urlAddress)
        {
            System.Net.WebRequest _webRequst;

            if (urlAddress.ToLower() == "unknown")
            {
                return false;
            }

            try
            {
                System.Uri url = new System.Uri(urlAddress);

                _webRequst = System.Net.WebRequest.Create(urlAddress); 
                NetworkCredential cred = new NetworkCredential(this.UserName, this.Password);
                _webRequst.Credentials = cred;

                if (this.UserName.Trim() == "" || this.Password.Trim() == "")
                {
                    throw new MediaServiceException("Username or password not set");
                }

                System.Net.WebResponse resp = _webRequst.GetResponse();
                resp.Close();
                _webRequst = null;
            }
            catch (Exception ex)
            {
                _webRequst = null;
                Logging.Instance.WriteLine(ex);
                return false;
            }

            return true;
            
        }

    }
}


