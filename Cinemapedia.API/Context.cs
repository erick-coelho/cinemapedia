using Cinemapedia.API.Map;
using Cinemapedia.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cinemapedia.API
{
    public class Context : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
