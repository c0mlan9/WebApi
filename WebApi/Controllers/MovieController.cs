using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Application.Movies.Commands.CreateMovie;
using WebApi.Application.Movies.Queries.GetMovie;
using WebApi.Application.Movies.Queries.GetMovies;
using WebApi.Domain.DTOs.Requests.Movie;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _mediator.Send(new GetMoviesQuery());

            if (movies != null)
                return Ok(movies);

            return NotFound("No movies in database. Please add a movie first.");
        }

        [HttpGet("/getmovies/{id}")]
        public async Task<ActionResult> GetMovie(int id)
        {
            var movie = await _mediator.Send(new GetMovieQuery(id));

            if (movie != null)
                return Ok(movie);

            return NotFound($"No movie in database with ID: {id}.");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovieAsync([FromBody] CreateMovieRequest request)
        {
            var movie = await _mediator.Send(new CreateMovieCommand(
                request.Title,
                request.Description,
                request.Genre,
                request.Rating
            ));

            return Ok(movie);
        }
    }
}
