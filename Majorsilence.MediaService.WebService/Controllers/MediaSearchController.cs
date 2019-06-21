using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Majorsilence.MediaService.Dto;
using Majorsilence.MediaService.RepoInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Majorsilence.MediaService.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaSearchController : ControllerBase
    {
        readonly IMediaSearchRepo repo;

        public MediaSearchController(IMediaSearchRepo repo)
        {
            this.repo = repo;
        }

        // GET api/values
        /// <summary>
        /// This service is used to search for media.  It will return
        /// IdMediaInfo, MediaName, Summary, Active, StoryLine, IdMediaType, IdLanguage,
        /// IdMotionPictureRating, AverageUserRating, MediaYear, LastAltered, MediaLength,
        /// CoverArtLocation
        ///
        /// The cover art location is a link to the location of the cover art and must be
        /// joined with the base url.
        ///
        /// If you want to stream a video you pass the IdMediaInfo id to the
        /// /api/mediafileinfo?search=id service.
        /// </summary>
        /// <example>
        /// Call /api/mediasearch?search=Your search terms
        /// </example>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MediaInfoSearch>>> Get(string search)
        {
            var results = await repo.SearchAsync(search);
            return results.ToList();
        }

    }
}
