using Dapper;
using Majorsilence.MediaService.Dto;
using Majorsilence.MediaService.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Majorsilence.DataAccess
{
    public class MediaSearchRepo : BaseRepo, IMediaSearchRepo
    {

        public MediaSearchRepo(string cnStr) : base(cnStr) { }

        public Task<IEnumerable<MediaInfoSearch>> SearchAsync(string searchTerm)
        {
            return this.WithConnectionAsync(cn =>
            {
                return cn.QueryAsync<MediaInfoSearch>("MediaInfoSLikeCmd", new { pMediaName  = searchTerm});
            });
        }
    }
}
