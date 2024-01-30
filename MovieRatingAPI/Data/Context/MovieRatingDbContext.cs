using Microsoft.EntityFrameworkCore;
using MovieRatingAPI.Data.Entities;

namespace MovieRatingAPI.Data.Context
{
    public class MovieRatingDbContext : DbContext
    {
        public MovieRatingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasData(
                new Rating
                {
                    RatingId = 1,
                    MovieId = 1,
                    Value = 1
                },
                new Rating
                {
                    RatingId = 2,
                    MovieId = 1,
                    Value = 2
                },
                new Rating
                {
                    RatingId = 3,
                    MovieId = 1,
                    Value = 2
                },
                new Rating
                {
                    RatingId = 4,
                    MovieId = 1,
                    Value = 5
                },
                new Rating
                {
                    RatingId = 5,
                    MovieId = 2,
                    Value = 1
                },
                new Rating
                {
                    RatingId = 6,
                    MovieId = 2,
                    Value = 4
                },
                new Rating
                {
                    RatingId = 7,
                    MovieId = 2,
                    Value = 4
                },
                new Rating
                {
                    RatingId = 8,
                    MovieId = 2,
                    Value = 4
                },
                new Rating
                {
                    RatingId = 9,
                    MovieId = 3,
                    Value = 1
                },
                new Rating
                {
                    RatingId = 10,
                    MovieId = 4,
                    Value = 2
                },
                new Rating
                {
                    RatingId = 11,
                    MovieId = 5,
                    Value = 3
                },
                new Rating
                {
                    RatingId = 12,
                    MovieId = 6,
                    Value = 4
                },
                new Rating
                {
                    RatingId = 13,
                    MovieId = 7,
                    Value = 5
                },
                new Rating
                {
                    RatingId = 14,
                    MovieId = 8,
                    Value = 1
                },
                new Rating
                {
                    RatingId = 15,
                    MovieId = 9,
                    Value = 2
                },
                new Rating
                {
                    RatingId = 16,
                    MovieId = 10,
                    Value = 2
                },
                new Rating
                {
                    RatingId = 17,
                    MovieId = 11,
                    Value = 2
                }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Killers of the flower moon",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/killers_of_the_flower_moon.jpg",
                    Resume = "Resume of Killers of the flower moon",
                    RealeaseDate = new DateTime(2023, 10, 20),
                    Starring = "Leonardo DiCaprio, Robert De Niro, Lily Gladstone",
                    Tags = "Crime, History, Drama"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Se7en",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/se7en.jpg",
                    Resume = "Resume of Se7en",
                    RealeaseDate = new DateTime(1995, 3, 20),
                    Starring = "Morgan Freeman, Brad Pitt, Kevin Spacey",
                    Tags = "Crime, Mystery, Drama",
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "The hateful eight",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/the_hateful_eight.jpg",
                    Resume = "Resume of The hateful eight",
                    RealeaseDate = new DateTime(2016, 2, 20),
                    Starring = "Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh",
                    Tags = "Crime, Mystery, Drama"
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "Kiss kiss bang bang",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/kiss_kiss_bang_bang.jpg",
                    Resume = "Resume for Kiss kiss bang bang",
                    RealeaseDate = new DateTime(2005, 7, 30),
                    Starring = "Robert Downey Jr., Val Kilmer, Michelle Monaghan",
                    Tags = "Crime, Comedy, Mystery"
                }, new Movie
                {
                    MovieId = 5,
                    Name = "The killer",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/the_killer.jpg",
                    Resume = "After a fateful near-miss, an assassin battles his employers and himself, on an international manhunt he insists isn't personal.",
                    RealeaseDate = new DateTime(2023, 4, 7),
                    Starring = "Michael Fassbender, Tilda Swinton, Charles Parnell",
                    Tags = "Crime, Action, Adventure"
                }, new Movie
                {
                    MovieId = 6,
                    Name = "Revolver",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/revolver.jpg",
                    Resume = "Resume of Revolver",
                    RealeaseDate = new DateTime(2005, 2, 20),
                    Starring = "Jason Statham, Ray Liotta, André 3000",
                    Tags = "Crime, Action, Drama"
                }, new Movie
                {
                    MovieId = 7,
                    Name = "Dune",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/dune.jpg",
                    Resume = "Resume of Dune",
                    RealeaseDate = new DateTime(2021, 8, 10),
                    Starring = "Timothée Chalamet, Rebecca Ferguson, Zendaya",
                    Tags = "Adventure, Action, Drama"
                }, new Movie
                {
                    MovieId = 8,
                    Name = "The whale",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/the_whale.jpg",
                    Resume = "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.",
                    RealeaseDate = new DateTime(2023, 10, 20),
                    Starring = "Brendan Fraser, Sadie Sink, Ty Simpkins",
                    Tags = "Drama"
                }
                , new Movie
                {
                    MovieId = 9,
                    Name = "American psycho",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/american_psycho.jpg",
                    Resume = "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.",
                    RealeaseDate = new DateTime(2000, 10, 20),
                    Starring = "Christian Bale, Justin Theroux, Josh Lucas",
                    Tags = "Drama, Crime, Horror"
                }, new Movie
                {
                    MovieId = 10,
                    Name = "The Lincoln lawyer",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/the_lincoln_lawyer.jpg",
                    Resume = "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.",
                    RealeaseDate = new DateTime(2011, 12, 2),
                    Starring = "Ryan Phillippe, Marisa Tomei, Matthew McConaughey",
                    Tags = "Drama, Crime, Mystery"
                }, new Movie
                {
                    MovieId = 11,
                    Name = "Public enemies",
                    Image = @"https://raw.githubusercontent.com/dirk-dagger-667/MovieRating/dev/MovieRatingApp/Resources/Images/public_enemies.jpg",
                    Resume = "The Feds try to take down notorious American gangsters John Dillinger, Baby Face Nelson, and Pretty Boy Floyd during a booming crime wave in the 1930s.",
                    RealeaseDate = new DateTime(2011, 4, 2),
                    Starring = "Christian Stolte, Johnny Depp, Christian Bale",
                    Tags = "Action, Crime, Biography"
                }
                );
        }
    }
}
