using Microsoft.EntityFrameworkCore;
using MovieRatingAPI.Data.Context;
using MovieRatingAPI.Data.Entities;

namespace MovieRatingAPI.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieRatingDbContext _context;

        public MovieRepository(MovieRatingDbContext movieRatingDbContext) 
        {
            _context = movieRatingDbContext;
        }

        public void Delete(int id) => _context.Remove(id);

        public async Task<bool> DoesItemExistByIdAsync(int id)
        {
            var exists = await FindByIdAsync(id);

            return exists != null ? true : false;
        }

        public async Task<bool> DoesMovieExistByNameAsync(string name)
        {
            var exists = await FindByNameAsync(name);

            return exists != null ? true : false;
        }

        public async Task<Movie?> FindByIdAsync(int id)
        {
            var exists = await _context.Set<Movie>()
                .AsQueryable()
                .Where(m => m.MovieId == id)
                .Include(m => m.Ratings)
                .FirstOrDefaultAsync();

            return exists;
        }

        public async Task<Movie?> FindByNameAsync(string name)
        {
            var exists = await _context.Set<Movie>()
                .AsQueryable()
                .Where(m => m.Name == name)
                .Include(m => m.Ratings)
                .FirstOrDefaultAsync();

            return exists;
        }

        public async Task<IEnumerable<Movie>?> GetAllMoviesAsync()
        {
            var all = await _context.Set<Movie>()
                .Include(m => m.Ratings)
                .ToListAsync();

            return all;
        }

        public void Insert(Movie movie) => _context.Add(movie);

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public void Update(Movie movie) => _context.Update(movie);
    }
}
