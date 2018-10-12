//using Chinook.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository.Interface
{
    public interface IArtistRepository:IGenericRepository<Artist>
    {
        IEnumerable<Artist> GetListByName(string name);

        IEnumerable<Artist> GetListByNameSP(string name);
    }
}
