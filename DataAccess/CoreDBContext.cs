using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CoreDBContext: DbContext
    {
        public CoreDBContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=192.168.20.213,1433;Database=TPCoreWeb;User ID=donetuser;Password=Thinkpower;Trusted_Connection=True;Integrated Security=False;");
            }
        }

    }
}
