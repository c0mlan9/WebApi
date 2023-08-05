using MediatR;
using System.Collections.Generic;
using WebApi.Domain.DTOs.Responses.Movie;

namespace WebApi.Application.Movies.Queries.GetMovies
{
    public class GetMoviesQuery : IRequest<IList<GetMovieDto>>
    {
    }
}
