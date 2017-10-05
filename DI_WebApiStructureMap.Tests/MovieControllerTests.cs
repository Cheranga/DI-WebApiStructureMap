using System;
using System.Web.Http.Results;
using DI_WebApiStructureMap.Controllers;
using DI_WebApiStructureMap.DAL;
using DI_WebApiStructureMap.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DI_WebApiStructureMap.Tests
{
    [TestClass]
    public class MovieControllerTests
    {
        [TestMethod]
        public void GetMovie_For_A_Valid_Id()
        {
            //
            // Arrange
            //
            var movieId = 1;
            var mockRepository = new Mock<IMovieRepository>();
                
                mockRepository.Setup(x => x.GetById(movieId)).Returns(new Movie
            {
                Id = movieId,
                Director = "Cheranga Hatangala",
                ReleaseDate = DateTime.Now.AddYears(-1),
                RunningTimeMinutes = 90,
                Title = "DI with StructureMap"
            });

            var controller = new MovieController(mockRepository.Object);
            //
            // Act
            //
            var httpResponse = controller.GetMovie(movieId) as OkNegotiatedContentResult<Movie>;
            //
            // Assert
            //
            Assert.IsNotNull(httpResponse);
            Assert.IsNotNull(httpResponse.Content);
            Assert.AreEqual(movieId, httpResponse.Content.Id);
        }

        [TestMethod]
        public void GetMovie_For_An_Invalid_Id()
        {
            //
            // Arrange
            //
            var movieId = 1;
            var mockRepository = new Mock<IMovieRepository>();

            mockRepository.Setup(x => x.GetById(movieId)).Returns(new Movie
            {
                Id = movieId,
                Director = "Cheranga Hatangala",
                ReleaseDate = DateTime.Now.AddYears(-1),
                RunningTimeMinutes = 90,
                Title = "DI with StructureMap"
            });

            var controller = new MovieController(mockRepository.Object);
            //
            // Act
            //
            var httpResponse = controller.GetMovie(2) as NotFoundResult;
            //
            // Assert
            //
            Assert.IsNotNull(httpResponse);
        }
    }
}
