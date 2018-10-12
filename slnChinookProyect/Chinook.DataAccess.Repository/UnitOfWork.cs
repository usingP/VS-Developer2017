using Chinook.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _contex;

        public IAlbumRepository AlbumRepository { get; private set; }

        public IArtistRepository ArtistRepository { get; private set; }

        public IInvoiceRepository InvoiceRepository { get; private set; }

        public IInvoiceLineRepository InvoiceLineRepository { get; private set; }

        public ICustomerRepository CustomerRepository { get; private set; }

        public ITrackRepository TrackRepository { get; private set; }

        public UnitOfWork(DbContext contex)
        {
            this._contex = contex;
            this.AlbumRepository = new AlbumRepository(this._contex);
            this.ArtistRepository = new ArtistRepository(this._contex);
            this.InvoiceRepository = new InvoiceRepository(this._contex);
            this.InvoiceLineRepository = new InvoiceLineRepository(this._contex);
            this.CustomerRepository = new CustomerRepository(this._contex);
            this.TrackRepository = new TrackRepository(this._contex);

        }

        public int Complete()
        {
            return _contex.SaveChanges();
        }

        public void Dispose()
        {
            _contex.Dispose();
        }
    }
}
