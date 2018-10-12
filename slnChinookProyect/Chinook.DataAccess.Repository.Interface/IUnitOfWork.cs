using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        //Se coloca todos los repositorios Interfaces
        IAlbumRepository AlbumRepository { get; }
        IArtistRepository ArtistRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        IInvoiceLineRepository InvoiceLineRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        ITrackRepository TrackRepository { get; }
        int Complete();
    }
}
