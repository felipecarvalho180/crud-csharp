using Microsoft.AspNetCore.Mvc;

namespace MoviesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
  private List<Movie> movies = new();

  [HttpPost]
  public void AddMovie([FromBody] Movie movie)
  {
    movies.Add(movie);
    Console.WriteLine(movie.Title);
    Console.WriteLine(movie.Duration);
  }
}