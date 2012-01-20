using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaServiceClient
{
    class VideoInfo
    {
        private VideoInfo() { }

        public VideoInfo(string name, string summary, long mediaInfoId)
        {
            this.Name = name;
            this.Summary = summary;
            this.MediaInfoId = mediaInfoId;
        }

        public string Name {get; set;}
        public string Summary { get; set; }
        public long MediaInfoId { get; set; }
    }

   


}
