using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CoreDBContext _context;

        public MovieRepository(CoreDBContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Get()
        {
            IQueryable<Movie> movies = _context.Movies;
            return movies;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
        }

        public void Remove(Movie movie)
        {
            _context.Movies.Remove(movie);
        }
    }
}
