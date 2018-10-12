using Chinook.DataAccess.Repository.Interface;
using Chinook.Entity.BaseQry;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class CustomerRepository:GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext pContext) : base(pContext)
        {

        }

        public IEnumerable<Entity.BaseQry.CustomerScriptSql.ForCustomerItem> GetForCustomerItem()
        {
            return this.context.Database.SqlQuery<CustomerScriptSql.ForCustomerItem>("usp_getForCustomerItem").ToList();
        }
    }
}
