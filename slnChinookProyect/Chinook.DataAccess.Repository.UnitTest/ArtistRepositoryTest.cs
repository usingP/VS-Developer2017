using System;
using System.Linq;
using System.Data.Entity;
using Chinook.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class ArtistRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly IArtistRepository artistRepository;

        private readonly IUnitOfWork unitOfWork;

        public ArtistRepositoryTest()
        {
            this.dbContext = new ChinookDBModel();
            this.artistRepository = new ArtistRepository(dbContext);

            this.unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void GetCount()
        {
            var count = this.artistRepository.Count();

            Assert.IsTrue(count > 0,"ok");
            //var =this.artistRepository.GetAll(0);
        }

        [TestMethod]
        public void GetListByName()
        {
            var artist = this.artistRepository.GetListByName("Bl");

            Assert.IsTrue(artist.Count() > 0, "ok");
            //var =this.artistRepository.GetAll(0);
        }

        [TestMethod]
        public void GetListByNameSP()
        {
            
            var artist = this.artistRepository.GetListByNameSP("%Bla%");

            Assert.IsTrue(artist.Count() > 0, "ok");
            //var =this.artistRepository.GetAll(0);
        }

        [TestMethod]
        public void GetCountAW()
        {
            var count = this.unitOfWork.ArtistRepository.Count();
            this.unitOfWork.Complete();
            this.unitOfWork.Dispose();

            Assert.IsTrue(count > 0, "ok");
        }

        [TestMethod]
        public void AddAW()
        {
            var artist = new Artist();

            artist.Name = "TestTest";
            this.unitOfWork.ArtistRepository.add(artist);
            this.unitOfWork.Complete();
            this.unitOfWork.Dispose();

            Assert.IsTrue(artist.ArtistId > 0, "ok");
        }


    }
}
