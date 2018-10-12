using Chinook.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class TrackRepository:GenericRepository<Track>,ITrackRepository
    {
        public TrackRepository(DbContext pContext) : base(pContext)
        {
            
        }

        public IEnumerable<Track> GetListTrackByName(string name)
        {
            return ((ChinookDBModel)this.context).Track.Where(item => item.Name.Contains(name)).ToList();
        }
    }
}
