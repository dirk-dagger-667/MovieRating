using MovieRatingApp.Services.Contracts;
using MovieRatingApp.Services.Implementations;
using MovieRatingApp.Views;

namespace MovieRatingApp.Extensions
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            //Views
            builder.Services.AddSingleton<MoviesPage>();
            builder.Services.AddTransient<MovieDetailsPage>();

            return builder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            //ViewModels
            builder.Services.AddSingleton<MoviesViewModel>();
            builder.Services.AddTransient<MovieDetailsViewModel>();

            return builder;
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            //Services
            builder.Services.AddSingleton<IMovieService, MovieService>();

            return builder;
        }
    }
}
