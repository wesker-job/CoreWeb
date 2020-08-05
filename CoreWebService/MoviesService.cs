using DataAccess;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebService
{
    public class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        /// <summary>
        /// 取得所有Movie資料
        /// </summary>
        /// <returns>Movies Data</returns>
        public IQueryable<Movie> Get()
        {
            return _movieRepository.Get();
        }

        public IQueryable<Movie> GetParam(string movieGenre, string searchString)
        {
            IQueryable<Movie> movies = this.Get();

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(c => c.Genre == movieGenre);
            }

            return movies;
        }

        public async Task<Movie> GetById(int id)
        {
            Movie movie = await this.Get().Where(x => x.Id == id).FirstOrDefaultAsync();
            return movie;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public void Update(Movie movie)
        {
            _movieRepository.Update(movie);
        }

        public void Remove(Movie movie)
        {
            _movieRepository.Remove(movie);
        }

        public async Task Save()
        {
            await _movieRepository.Save();
        }
    }
}
