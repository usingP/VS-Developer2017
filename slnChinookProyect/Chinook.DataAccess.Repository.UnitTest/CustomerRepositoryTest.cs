using System;
using System.Data.Entity;
using System.Linq;
using Chinook.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly ICustomerRepository customerRepository;

        private readonly IUnitOfWork unitOfWork;

        public CustomerRepositoryTest()
        {
            this.dbContext = new ChinookDBModel();
            this.customerRepository = new CustomerRepository(dbContext);

            this.unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void Get()
        {
            var customer = this.customerRepository.GetAll();
            Assert.IsTrue(customer.Count() > 0, "ok");
        }
    }
}
