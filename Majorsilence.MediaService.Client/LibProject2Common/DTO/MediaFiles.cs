using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Majorsilence.MediaService.Client.Common.DTO
{
    public class MediaFiles
    {
        public int IdMediaFiles { get; set; }
        public int IdMediaInfo { get; set; }
        public string FileLocation { get; set; }
        public int VideoBitrate { get; set; }
        public string MediaFileTypeCode { get; set; }
        public int MediaLength { get; set; }
    }
}
