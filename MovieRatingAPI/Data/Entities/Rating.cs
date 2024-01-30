namespace MovieRatingAPI.Data.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Value { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
    }
}
