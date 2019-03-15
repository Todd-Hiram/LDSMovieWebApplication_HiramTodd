using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LDSMovieWebApplication_HiramTodd.Models
{
    public class MovieGenreViewModels
    { 
            public List<Movie> Movies;
            public SelectList Genres;
            public string MovieGenre { get; set; }
            public string SearchString { get; set; }
    }
}
