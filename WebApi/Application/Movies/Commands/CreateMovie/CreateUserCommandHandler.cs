using MediatR;
using System.Threading;
using System.Threading.Tasks;

using WebApi.Domain.DTOs.Responses.Movie;
using WebApi.Repository.Context;


namespace WebApi.Application.Movies.Commands.CreateMovie
{
    public class CreateUserCommandHandler : IRequestHandler<CreateMovieCommand, CreateMovieDto>
    {
        private readonly ApplicationDBContext _dbContext;

        public CreateUserCommandHandler(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateMovieDto> Handle(CreateMovieCommand reques, CancellationToken cancellationToken)
        {
            var movie = reques.CreateMovie();
            await _dbContext.Movies.AddAsync(movie);
            await _dbContext.SaveChangesAsync();

            return new CreateMovieDto(movie.Id);
        }
    }
}
