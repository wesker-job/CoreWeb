using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebService
{
    public interface IMoviesService
    {
        IQueryable<Movie> Get();

        IQueryable<Movie> GetParam(string movieGenre, string searchString);

        Task<Movie> GetById(int id);

        void Add(Movie movie);

        void Update(Movie movie);

        void Remove(Movie movie);

        Task Save();
    }
}