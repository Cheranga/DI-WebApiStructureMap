using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DI_WebApiStructureMap.DAL.Repositories;

namespace DI_WebApiStructureMap.Controllers
{
    [RoutePrefix("api/movies")]
    public class MovieController : ApiController
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {   
            _movieRepository = movieRepository;
        }

        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetAll()
        {
            var movies = _movieRepository.GetAllMovies();

            return Ok(movies);
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _movieRepository.GetById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }
    }
}