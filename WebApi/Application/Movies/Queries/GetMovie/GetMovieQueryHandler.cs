using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using WebApi.Domain.DTOs.Responses.Movie;
using WebApi.Repository.Context;

namespace WebApi.Application.Movies.Queries.GetMovie
{
    public class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, GetMovieDto>
    {
        private readonly ApplicationDBContext _dbContext;

        public GetMovieQueryHandler(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetMovieDto> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var movie = await _dbContext.Movies.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (movie != null) 
            {
                var movieItem = movie.MapTo();
                return movieItem;
            }

            return null;
        }
    }
}
