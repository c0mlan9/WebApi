﻿using WebApi.Core.Enums;

namespace WebApi.Domain.DTOs.Responses.Movie
{
    public class GetMovieDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
    }
}
