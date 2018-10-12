using System;
using System.Data.Entity;
using Chinook.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class InvoiceRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IUnitOfWork unitOfWork;

        public InvoiceRepositoryTest()
        {
            this.dbContext = new ChinookDBModel();
            this.invoiceRepository = new InvoiceRepository(dbContext);
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void Add()
        {
            var invoice = new Invoice();
            invoice.CustomerId = 1;
            invoice.InvoiceDate = DateTime.Now;
            invoice.BillingAddress = "AV. rey 1520";
            invoice.BillingCity = "Lima";
            invoice.BillingState = "Lima";
            invoice.BillingCountry = "Peru";
            invoice.BillingPostalCode = "Lima 32";

            invoice.InvoiceLine = new List<InvoiceLine>();
            invoice.InvoiceLine.Add( new InvoiceLine()
            {
                TrackId=1,
                Quantity=2,
                UnitPrice=10
            });
            invoice.InvoiceLine.Add(new InvoiceLine()
            {
                TrackId = 2,
                Quantity = 3,
                UnitPrice = 50
            });
            invoice.InvoiceLine.Add(new InvoiceLine()
            {
                TrackId = 3,
                Quantity = 3,
                UnitPrice = 30
            });

            invoice.Total=invoice.InvoiceLine.Sum(item=>item.UnitPrice*item.Quantity);


            this.invoiceRepository.add(invoice);
            unitOfWork.Complete();
            unitOfWork.Dispose();

            Assert.IsTrue(invoice.InvoiceId > 0, "ok");
        }
    }
}
