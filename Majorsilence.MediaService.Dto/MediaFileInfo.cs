using System;
using System.Collections.Generic;
using System.Text;

namespace Majorsilence.MediaService.Dto
{
    public class MediaFileInfo
    {
        public long IdMediaFiles { get; set; }
        public long IdMediaInfo { get; set; }
        public string FileLocation { get; set; }
        public int VideoBitrate { get; set; }
        public string MediaFileTypeCode { get; set; }
        public int MediaLength { get; set; }
    }
}
