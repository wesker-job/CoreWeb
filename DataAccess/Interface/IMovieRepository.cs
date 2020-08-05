using Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Get();

        void Add(Movie movie);

        void Update(Movie movie);

        void Remove(Movie movie);

        Task Save();
    }
}