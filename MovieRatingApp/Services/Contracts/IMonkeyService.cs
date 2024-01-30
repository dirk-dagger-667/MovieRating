using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Services.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
    }
}
