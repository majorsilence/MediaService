using System;
using System.Data;

using System.IO;
using System.Net;
using System.Collections.Generic;
using LibMediaServiceCommon;
using System.Xml;


namespace LibMediaServiceCommon
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
        public List<DTO.MediaInfo> Search(string mediaName, string category)
        {

            mediaName = LibMediaServiceCommon.Base64.EncodeTo64(mediaName);
            category = LibMediaServiceCommon.Base64.EncodeTo64(category);


            string searchUrl = string.Format("{0}/media_info.php/?search={1}", Downloads.Instance.ServiceAddress,
                 mediaName);

            if (category.Trim() != "")
            {
                searchUrl += string.Format("&category={0}", category);
            }

            string data = LibMediaServiceCommon.Downloads.Instance.GetData(searchUrl);
            List<DTO.MediaInfo> a = ServiceStack.Text.JsonSerializer.DeserializeFromString<List<DTO.MediaInfo>>(data);

            return a;
            
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

            string searchUrl = string.Format("{0}/media_files.php?search={1}", Downloads.Instance.ServiceAddress, 
                mediaId);
            string data = LibMediaServiceCommon.Downloads.Instance.GetData(searchUrl);

            List<DTO.MediaFiles> a = ServiceStack.Text.JsonSerializer.DeserializeFromString<List<DTO.MediaFiles>>(data);


            string resultURL = "";
            foreach (DTO.MediaFiles item in a)
            {
                if (item.MediaFileTypeCode == "VIDEO")
                {
                    // TODO: Fix so it returns best matching bitrate for internet bandwidth.
                    resultURL = item.FileLocation;
                    break;
                }
            }
            

            return resultURL;
        }

    }
}

