namespace MovieRatingApp.Views
{
    public partial class MoviesPage : ContentPage
    {
        public MoviesPage(MoviesViewModel moviesViewModel)
        {
            InitializeComponent();
            BindingContext = moviesViewModel;
        }
    }

}
