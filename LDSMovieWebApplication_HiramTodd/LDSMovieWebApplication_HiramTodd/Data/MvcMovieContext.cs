using Microsoft.EntityFrameworkCore;

namespace LDSMovieWebApplication_HiramTodd.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMovieWebApplication_HiramTodd.Models.Movie> Movie { get; set; }
    }
}