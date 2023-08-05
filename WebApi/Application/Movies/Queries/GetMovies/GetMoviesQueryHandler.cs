using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using WebApi.Domain.DTOs.Responses.Movie;
using WebApi.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Application.Movies.Queries.GetMovies
{
    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IList<GetMovieDto>>
    {
        private readonly ApplicationDBContext _dbContext;

        public GetMoviesQueryHandler(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetMovieDto>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            var movies = await _dbContext.Movies.ToListAsync();
            var movieList = new List<GetMovieDto>();

            foreach (var movieItem in movies)
            {
                var movie = movieItem.MapTo();
                movieList.Add(movie);
            }

            return movieList;
        }
    }
}
