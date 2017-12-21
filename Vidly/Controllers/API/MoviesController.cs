﻿using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // /api/customers
        public IHttpActionResult GetMovies()
        {
            return Ok(_context.Movies.Select(Mapper.Map<Movie, MovieDto>));
        }

        // /api/customers/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                return BadRequest();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }


        // /api/customers
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movie);
        }

        [HttpPut]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);

            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);

            Mapper.Map<MovieDto, Movie>(movieDto, movie);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);


            _context.SaveChanges();
        }

    }
}
