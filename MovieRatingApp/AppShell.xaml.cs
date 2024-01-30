using MovieRatingApp.Views;

namespace MovieRatingApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MovieDetailsPage), typeof(MovieDetailsPage));
        }
    }
}
