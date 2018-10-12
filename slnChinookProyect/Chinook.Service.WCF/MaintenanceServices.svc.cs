using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Chinook.DataAccess.Repository;
using Chinook.DataAccess.Repository.Interface;

namespace Chinook.Service.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MaintenanceServices : IMaintenanceServices
    {
        private readonly DbContext dbContext;
        private readonly IUnitOfWork unitOfWork;

        public MaintenanceServices()
        {
            this.dbContext = new ChinookDBModel();
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        public IEnumerable<Artist> GetArtistByName(string artistName)
        {
            return unitOfWork.ArtistRepository.GetListByName(artistName);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
