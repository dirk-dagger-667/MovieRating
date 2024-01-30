namespace MovieRatingAPI.Models
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string? Name { get; set; }
        public string? Resume { get; set; }
        public string? Image { get; set; }
        public double Rating { get; set; }
        public DateTime RealeaseDate { get; set; }
        public IEnumerable<string>? Tags { get; set; }
        public IEnumerable<string>? Starring { get; set; }
    }
}
