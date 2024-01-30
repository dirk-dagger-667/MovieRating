using MovieRatingAPI.Models;

namespace MovieRatingAPI.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetMoviesAsync();
        Task<MovieDto> RateAsync(int id, int rating);
        Task<MovieDto> UpdateAsync(MovieDto movieDto);
    }
}
