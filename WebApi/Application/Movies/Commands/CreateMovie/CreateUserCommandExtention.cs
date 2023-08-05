using System.Collections.Generic;
using WebApi.Domain.Entities.Movie;

namespace WebApi.Application.Movies.Commands.CreateMovie
{
    public static class CreateUserCommandExtention
    {
        public static Movie CreateMovie(this CreateMovieCommand cmd)
        {
            var movie = new Movie
            (
                cmd.Title,
                cmd.Description,
                cmd.Genre,
                cmd.Rating
            );

            return movie;
        }
    }
}
