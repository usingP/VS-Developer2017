using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository.Interface
{
    public interface ITrackRepository:IGenericRepository<Track>
    {
        IEnumerable<Track> GetListTrackByName(string name);
    }
}
