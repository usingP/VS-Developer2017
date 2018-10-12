using Chinook.DataAccess.Repository.Interface;
//using Chinook.Entity.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class ArtistRepository:GenericRepository<Artist>,IArtistRepository
    {
        public ArtistRepository(DbContext pContext):base(pContext)
        {

        }

        public IEnumerable<Artist> GetListByName(string name)
        {
            return ((ChinookDBModel)this.context).Artist.Where(item => item.Name.Contains(name)).ToList();
            //throw new NotImplementedException();
        }

        public IEnumerable<Artist> GetListByNameSP(string name)
        {
            return context.Database.SqlQuery<Artist>("usp_GetListByNameSP @Name", new SqlParameter("@Name",name)).ToList();
        }
    }
}
