using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Majorsilence.MediaService.Client.Common.DTO
{
    public class MediaInfo
    {
        public long IdMediaInfo { get; set; }
        public string MediaName { get; set; }
        public string Summary { get; set; }
        public bool Active { get; set; }
        public string StoryLine { get; set; }
        public string IdMediaType { get; set; }
        public int IdLanguage { get; set; }
        public int IdMotionPictureRating { get; set; }
        public int AverageUserRating { get; set; }
        public int MediaYear { get; set; }
        public DateTime LastAltered { get; set; }
        public int MediaLength { get; set; }
        public string CoverArtLocation { get; set; }
    }
}
