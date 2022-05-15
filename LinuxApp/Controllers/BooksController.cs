using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("books")]
public class BooksController : ControllerBase
{
    private static IEnumerable<Book> _books = new[]
    {
        new Book
        {
            Id = 1,
            Author = "Jerome David Salinger",
            Name = "The catcher in the rye",
            Genre = "Fiction",
            Pages = 234
        },
        new Book
        {
            Id = 2,
            Author = "Walter Isaacson",
            Name = "Steve Jobs",
            Genre = "Biography",
            Pages = 656
        },
        new Book
        {
            Id = 3,
            Author = "Jack London",
            Name = "Martin Eden",
            Genre = "Drama",
            Pages = 448
        },
    };

    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Book> Get()
    {
        return _books.ToArray();
    }
}