using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("movies")]
public class MoviesController : ControllerBase
{
    private static IEnumerable<Movie> _movies = new[]
    {
        new Movie
        {
            Id = 1,
            Director = "Quentin Tarantino",
            Name = "Reservoir Dogs",
            Genre = "Crime",
        },
        new Movie
        {
            Id = 2,
            Director = "Quentin Tarantino",
            Name = "The Hateful Eight",
            Genre = "Western",
        },
        new Movie
        {
            Id = 3,
            Director = "Christopher Nolan",
            Name = "Tenet",
            Genre = "Action",
        },
    };

    private readonly ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Movie> Get()
    {
        return _movies.ToArray();
    }
}