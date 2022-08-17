using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Web_API_using_asp.net_web_application.Models;

namespace Web_API_using_asp.net_web_application.Controllers
{
    public class MoviesController : ApiController
    {
        Movie[] movies = new Movie[]
        {
            new Movie { Id = 1 , Name = "Titanic", Genre= "Drama", Price = 9},
            new Movie { Id = 1 , Name = "Titanic", Genre= "Drama", Price = 9},
            new Movie { Id = 1 , Name = "Titanic", Genre= "Drama", Price = 9}
        };
        // GET: Movies
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;  
        }


        public IHttpActionResult GetMovie(int id)
        {
            var movie = movies.FirstOrDefault((p) => p.Id == id);
            if(movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}