using System;
using System.Data;

using System.IO;
using System.Net;
using LibProject2Common;
using System.Xml;


namespace Project2GUI
{
    public class SearchMedia
    {
        public SearchMedia ()
        {
        }
        
        
        /// <summary>
        /// Returns a maximum of 20 videos. 
        /// </summary>
        /// <param name="mediaName">
        /// A <see cref="System.String"/>
        /// </param>
        /// <returns>
        /// A <see cref="DataTable"/>
        /// </returns>
        public DataTable Search(string mediaName, string category)
        {

            mediaName = LibProject2Common.Base64.EncodeTo64(mediaName);
            category = LibProject2Common.Base64.EncodeTo64(category);


            string searchUrl = string.Format("http://127.0.0.1:8080/MediaInfo/?search={0}", mediaName);

            if (category.Trim() != "")
            {
                searchUrl += string.Format("&category={0}", category);
            }

            string data = LibProject2Common.Downloads.Instance.Client.DownloadString(searchUrl);
      
            DataSet ds = new DataSet();	
            ds.ReadXml(new System.IO.StringReader(data));
        
            return ds.Tables[0];
        }



        /// <summary>
        /// Returns 1 link for a video.
        /// </summary>
        /// <param name="mediaName">
        /// A <see cref="System.String"/>
        /// </param>
        /// <returns>
        /// A <see cref="DataTable"/>
        /// </returns>
        public string Search(long mediaId)
        {

            string searchUrl = string.Format("http://127.0.0.1:8080/MediaFiles/?search={0}", mediaId);
            string data = LibProject2Common.Downloads.Instance.Client.DownloadString(searchUrl);

            DataSet ds = new DataSet();
            ds.ReadXml(new System.IO.StringReader(data));


            string resultURL = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["MediaFileTypeCode"].ToString().Trim().ToLower() == "video")
                {
                    // TODO: Fix so it returns best matching bitrate for internet bandwidth.
                    resultURL = row["FileLocation"].ToString().ToString();
                    break;
                }
            }
            

            return resultURL;
        }

    }
}

