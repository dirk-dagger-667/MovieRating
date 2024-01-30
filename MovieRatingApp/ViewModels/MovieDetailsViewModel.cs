namespace MovieRatingApp.ViewModels
{
    [QueryProperty(nameof(Movie), nameof(Movie))]
    public partial class MovieDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Movie movie;

        public MovieDetailsViewModel()
        {
                
        }
    }
}
