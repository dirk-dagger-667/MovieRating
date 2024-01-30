using MovieRatingAPI.Data.Entities;

namespace MovieRatingAPI.Data.Repositories
{
    public interface IMovieRepository
    {
        Task<bool> DoesItemExistByIdAsync(int id);
        Task<bool> DoesMovieExistByNameAsync(string name);
        Task<IEnumerable<Movie>?> GetAllMoviesAsync();
        Task<Movie?> FindByIdAsync(int id);
        Task<Movie?> FindByNameAsync(string name);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        Task SaveChangesAsync();
    }
}
