using System.Collections.Generic;
using System.Threading.Tasks;
using Majorsilence.MediaService.Dto;

namespace Majorsilence.MediaService.RepoInterfaces
{
    public interface IMediaSearchRepo
    {
       Task<IEnumerable<MediaInfoSearch>> SearchAsync(string searchTerm);
    }
}