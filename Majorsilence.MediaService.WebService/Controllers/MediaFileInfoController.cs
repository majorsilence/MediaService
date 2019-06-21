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
    public class MediaFileInfoController : ControllerBase
    {
        readonly IMediaFileInfoRepo repo;

        public MediaFileInfoController(IMediaFileInfoRepo repo)
        {
            this.repo = repo;
        }

        // GET api/values
        /// <summary>
        /// This service is used to retrieve video address so they 
        /// can be streamed.  It will return
        /// IdMediaFiles, IdMediaInfo, FileLocation, VideoBitrate(in kb), 
        /// MediaFileTypeCode, MediaLength(in seconds)
        ///
        /// The file location is a link to the location of the cover art and must be
        /// joined with the base url.
        /// 
        /// A video id is included when you do a search for file using 
        /// /api/mediasearch?search=Your search terms.
        /// </summary>
        /// <example>
        /// Call /api/mediafileinfo?search=id service.
        /// </example>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MediaFileInfo>>> Get(int id)
        {
            var results = await repo.SearchAsync(id);
            return results.ToList();
        }

    }
}
