using MediatR;
using WebApi.Core.Enums;
using WebApi.Domain.DTOs.Responses.Movie;

namespace WebApi.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommand : IRequest<CreateMovieDto>
    {
        public CreateMovieCommand(string? title, string? description, MovieGenre? genre, int? rating)
        {
            Title = title;
            Description = description;
            Rating = rating;
            Genre = genre;
        }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Rating { get; set; }
        public MovieGenre? Genre { get; set; }
    }
}
