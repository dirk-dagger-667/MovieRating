namespace MovieRatingApp.Views;

public partial class MovieDetailsPage : ContentPage
{
	public MovieDetailsPage(MovieDetailsViewModel movieDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = movieDetailsViewModel;

    }
}