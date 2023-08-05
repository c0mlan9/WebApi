namespace WebApi.Domain.DTOs.Responses.Movie
{
    public class CreateMovieDto
    {
        public CreateMovieDto(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
