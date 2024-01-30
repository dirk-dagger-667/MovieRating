using MovieRatingApp.Constants;
using MovieRatingApp.Services.Contracts;
using System.Net.Http.Json;

namespace MovieRatingApp.Services.Implementations
{
    public class MovieService : IMovieService
    {
        IEnumerable<Movie> movies = new List<Movie>();
        HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            if (movies.Any())
            {
                return movies;
            }

            try
            {
                Uri uri = new Uri(string.Format($"{AppConstants.BaseApiUrl}{AppConstants.Movie}/GetAll", string.Empty));
                var response = await _httpClient.GetFromJsonAsync<IEnumerable<Movie>>(uri);
                movies = response ?? movies;
            }
            catch (Exception ex)
            {

                throw;
            }

            //using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
            //using var reader = new StreamReader(stream);
            //var contents = await reader.ReadToEndAsync();
            //movies = await JsonSerializer.DeserializeAsync<IEnumerable<Movie>>(stream) ?? movies;

            return movies;
        }
    }
}
