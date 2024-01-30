using MovieRatingApp.Extensions;
using MovieRatingApp.Services.Contracts;
using MovieRatingApp.Views;

namespace MovieRatingApp.ViewModels
{
    public partial class MoviesViewModel : BaseViewModel
    {
        private IMovieService _movieService;

        [ObservableProperty]
        public ObservableCollection<Movie> movies = new();

        public MoviesViewModel(IMovieService movieService)
        {
            Title = "Movie Rating";
            _movieService = movieService;
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(Movie movie)
        {
            if (movie is null)
            {
                return;
            }

            var movieTypeName = typeof(Movie).Name;

            await Shell.Current.GoToAsync($"{nameof(MovieDetailsPage)}",
                true,
                new Dictionary<string, object>() 
                {
                    { movieTypeName, movie } 
                });
        }

        [RelayCommand]
        private async Task GetMovies()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;

                var movies = await _movieService.GetMoviesAsync();

                if (movies.Any())
                {
                    Movies.Clear();
                }

                Movies = movies.ConvertToObservableCollection();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!!!", $"Unable to get movies : {ex.Message}", "Exit"); //Abstract into a panel, don't leave it here since you're making changes to the UI from the ViewModel.
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
