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
    public class BaseAddressController : ControllerBase
    {

        /// <summary>
        /// 
        ///This service will return list of base media addresses that can be
        ///used to stream video and cover art.
        ///
        ///Returns Address
        ///
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<BaseAddressInfo>> Get()
        {
            // TODO: switch this to a config file or database
            var list = new List<BaseAddressInfo>();
            list.Add(new BaseAddressInfo()
            {
                Address = "http://files.majorsilence.com/mediaservice/"
            });
            return list;
        }

    }

    public class BaseAddressInfo
    {
        public string Address { get; set; }
    }
}
