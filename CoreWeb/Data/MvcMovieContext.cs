using Microsoft.EntityFrameworkCore;

namespace CoreWeb.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {
        }

        //public DbSet<Movie> Movies { get; set; }
    }
}
