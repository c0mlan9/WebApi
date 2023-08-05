using MediatR;
using System.Collections.Generic;
using WebApi.Domain.DTOs.Responses.Movie;

namespace WebApi.Application.Movies.Queries.GetMovie
{
    public class GetMovieQuery : IRequest<GetMovieDto>
    {
        public GetMovieQuery(int? id)
        {
            Id = id;
        }

        public int? Id { get; set; }
    }
}
