using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LDSMovieWebApplication_HiramTodd.Models;

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