using Microsoft.AspNetCore.Mvc;
using MovieRatingAPI.Models;
using MovieRatingAPI.Services;

namespace MovieRatingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetAll()
        {
            var result = await _movieService.GetMoviesAsync();

            if (result == null) return NoContent();

            return Ok(result);
        }

        [HttpPatch]
        public async Task<ActionResult<MovieDto>> Rate([FromBody]RatingDto ratingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ratedMovie = await _movieService.RateAsync(ratingDto.Id, ratingDto.Rating);

            if (ratedMovie.MovieId == 0)
            {
                return NoContent();
            }

            return Ok(ratedMovie);
        }
    }
}
