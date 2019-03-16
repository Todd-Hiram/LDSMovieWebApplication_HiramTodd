using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LDSMovieWebApplication_HiramTodd.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Single's Ward",
                        ReleaseDate = DateTime.Parse("2004-2-1"),
                        Genre = "Comedy, Drama",
                        Rating = "PG",
                        Price = 10.50M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Adventure, Biography, Drama",
                        Rating = "PG",
                        Price = 14.98M
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-1-1"),
                        Genre = "Biography, Drama, History",
                        Rating = "None",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 4.75M
                    },

                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-3-10"),
                        Genre = "Religious",
                        Rating = "PG",
                        Price = 15.66M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}