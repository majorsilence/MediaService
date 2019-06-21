using System;

namespace Majorsilence.MediaService.Dto
{
    public class MediaInfoSearch
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
        public long MediaLength { get; set; }
        public string CoverArtLocation { get; set; }
    }
}
