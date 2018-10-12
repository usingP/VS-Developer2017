using System;
using System.Data.Entity;
using System.Linq;
using Chinook.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class TrackRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly ITrackRepository trackRepository;

        private readonly IUnitOfWork unitOfWork;

        public TrackRepositoryTest()
        {
            this.dbContext = new ChinookDBModel();
            this.trackRepository = new TrackRepository(dbContext);

            this.unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void GetById()
        {
            var track = this.trackRepository.GetById(1);
            //1 - FirstName LastName
            Assert.IsTrue(track.TrackId > 0, "ok");
        }
    }
}
