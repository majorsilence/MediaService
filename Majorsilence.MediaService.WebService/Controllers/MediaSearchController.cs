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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MediaInfoSearch>>> Get(string searchTerm)
        {
            var results = await repo.SearchAsync(searchTerm);
            return results.ToList();
        }

    }
}
