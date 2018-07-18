using AutoMapper;
using Mosh.Vidly.Dtos;
using Mosh.Vidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Mosh.Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _db.Dispose();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _db.Movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            var movie = _db.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return movie;
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _db.Movies.Add(movie);
            _db.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movie);
        }

        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _db.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            movieInDb.Name = movie.Name;
            movieInDb.NumberInStock = movie.NumberInStock;
            movieInDb.GenreId = movie.GenreId;
            _db.SaveChanges();
        }

        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var movieInDb = _db.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _db.Movies.Remove(movieInDb);
            _db.SaveChanges();
        }
    }
}
