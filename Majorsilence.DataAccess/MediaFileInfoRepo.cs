using Dapper;
using Majorsilence.MediaService.Dto;
using Majorsilence.MediaService.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Majorsilence.DataAccess
{
    public class MediaFileInfoRepo : BaseRepo, IMediaFileInfoRepo
    {
        public MediaFileInfoRepo(string cnStr) : base(cnStr) { }

        public Task<IEnumerable<MediaFileInfo>> SearchAsync(long id)
        {
            return this.WithConnectionAsync(cn =>
            {
                return cn.QueryAsync<MediaFileInfo>("MediaFilesSCmd", new { pIdMediaInfo = id });
            });
        }
    }
}
