using WebApi.Domain.DTOs.Responses.Movie;
using WebApi.Domain.Entities.Movie;

namespace WebApi.Application.Movies.Queries.GetMovies
{
    public static class GetMoviesQueryExtentions
    {
        public static GetMovieDto MapTo(this Movie movie)
        {
            return new GetMovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Rating = movie.Rating
            };
        }
    }
}
