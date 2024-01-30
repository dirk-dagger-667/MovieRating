using MovieRatingAPI.Data.Repositories;
using MovieRatingAPI.Services;

namespace MovieRatingAPI.Extensions
{
    public static class DIConfiguration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services) 
        {
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped<IMovieRepository, MovieRepository>();

            return services;
        }
    }
}
