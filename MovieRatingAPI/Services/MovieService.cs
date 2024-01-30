using MovieRatingAPI.Data.Entities;
using MovieRatingAPI.Data.Repositories;
using MovieRatingAPI.Extensions;
using MovieRatingAPI.Models;

namespace MovieRatingAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<MovieDto>> GetMoviesAsync()
        {
            try
            {
                var allMoviesDb = await _movieRepository.GetAllMoviesAsync();

                if (allMoviesDb == null)
                {
                    return new List<MovieDto>();
                }

                var allMovieDtos = allMoviesDb.Select(mdb => mdb.MapToDto());

                await _movieRepository.SaveChangesAsync();

                return allMovieDtos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<MovieDto> RateAsync(int id, int rating)
        {
            try
            {
                var found = await _movieRepository.FindByIdAsync(id);

                if (found == null) return new MovieDto();

                found.Ratings.Add(new Rating { MovieId = id, Value = rating });

                _movieRepository.Update(found);

                await _movieRepository.SaveChangesAsync();

                return found.MapToDto();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<MovieDto> UpdateAsync(MovieDto movieDto)
        {
            try
            {
                var exists = await _movieRepository.FindByIdAsync(movieDto.MovieId);

                if (exists == null)
                {
                    return new MovieDto();
                }

                var movieEntity = movieDto.MapToEntity();

                _movieRepository.Update(movieEntity);

                await _movieRepository.SaveChangesAsync();

                return movieDto;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
