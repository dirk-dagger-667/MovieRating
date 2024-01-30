using MovieRatingAPI.Data.Entities;
using MovieRatingAPI.Models;

namespace MovieRatingAPI.Extensions
{
    public static class MovieMapper
    {
        public static MovieDto MapToDto(this Movie movie)
        {
            var dto = new MovieDto()
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Image = movie.Image,
                RealeaseDate = movie.RealeaseDate,
                Resume = movie.Resume,
                Rating = movie.Ratings.Average(m => m.Value),
                Starring = movie.Starring != null ? movie.Starring.Split(", ") : new List<string>(),
                Tags = movie.Tags != null ? movie.Tags.Split(", ") : new List<string>()
            };

            return dto;
        }

        public static Movie MapToEntity(this MovieDto movie)
        => new Movie()
        {
            MovieId = movie.MovieId,
            Name = movie.Name,
            Image = movie.Image,
            RealeaseDate = movie.RealeaseDate,
            Resume = movie.Resume,
            Starring = movie.Starring != null ? string.Join(", ", movie.Starring) : null,
            Tags = movie.Tags != null ? string.Join(", ", movie.Tags) : null
        };
    }
}
