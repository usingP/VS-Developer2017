using System;
using System.Data.Entity;
using Chinook.DataAccess.Repository.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Chinook.DataAccess.Repository.UnitTest
{
    [TestClass]
    public class AlbumRepositoryTest
    {
        private readonly DbContext dbContext;
        private readonly IAlbumRepository albumRepository;
        private readonly IUnitOfWork unitOfWork;

        public AlbumRepositoryTest()
        {
            this.dbContext = new ChinookDBModel();
            this.albumRepository = new AlbumRepository(dbContext);
            this.unitOfWork = new UnitOfWork(dbContext);
        }

        [TestMethod]
        public void GetCount()
        {
            var count = this.albumRepository.Count();

            Assert.IsTrue(count > 0, "ok");
        }

        [TestMethod]
        public void Add()
        {
            var album = new Album();
            //album.AlbumId = 349;
            album.Title = "rtyuiouytruuuuuuuuuuuuui";
            album.ArtistId = 200;

            this.albumRepository.add(album);
            dbContext.SaveChanges();

            Assert.IsTrue(album.AlbumId > 0, "ok");
        }

        [TestMethod]
        public void GetAll()
        {
            var album = this.albumRepository.GetAll();

            Assert.IsTrue(album.Count() > 0, "ok");
        }

        [TestMethod]
        public void GetById()
        {
           var album = this.albumRepository.GetById(348);

            Assert.IsTrue(album.AlbumId > 0, "ok");
        }


        [TestMethod]
        public void Remove()
        {
            var album = new Album();
            album.AlbumId = 350;
            this.albumRepository.Remove(album);

            Assert.IsTrue(dbContext.SaveChanges() > 0, "ok");
        }

        [TestMethod]
        public void Update()
        {
            var album = new Album();
            album.AlbumId = 349;
            this.albumRepository.Update(album);

            Assert.IsTrue(dbContext.SaveChanges() > 0, "ok");
        }

        [TestMethod]
        public void GetAlbunesSales()
        {

            var albumSales = this.unitOfWork.AlbumRepository.GetAlbunesSales();
            this.unitOfWork.Dispose();

            Assert.IsTrue(albumSales.Count() > 0, "ok");
        }

    }
}
