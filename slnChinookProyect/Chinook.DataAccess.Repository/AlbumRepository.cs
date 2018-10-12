using Chinook.DataAccess.Repository.Interface;
using Chinook.Entity.BaseQry;
//using Chinook.Entity.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class AlbumRepository: GenericRepository<Album>,IAlbumRepository
    {
        public AlbumRepository(DbContext pContext) : base(pContext)
        {

        }

        public IEnumerable<AlbumSaleQry> GetAlbunesSales()
        {
            return this.context.Database.SqlQuery<AlbumSaleQry>("usp_getAlbunesSales").ToList();
        }
    }
}
