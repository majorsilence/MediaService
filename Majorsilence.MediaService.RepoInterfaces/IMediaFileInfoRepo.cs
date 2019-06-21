using System.Collections.Generic;
using System.Threading.Tasks;
using Majorsilence.MediaService.Dto;

namespace Majorsilence.MediaService.RepoInterfaces
{
    public interface IMediaFileInfoRepo
    {
        Task<IEnumerable<MediaFileInfo>> SearchAsync(long id);
    }
}