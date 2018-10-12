using Chinook.Entity.BaseQry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository.Interface
{
    public interface ICustomerRepository:IGenericRepository<Customer>
    {
        IEnumerable<CustomerScriptSql.ForCustomerItem> GetForCustomerItem();
    }
}
