using System.Text.Json.Serialization;

namespace MovieRatingApp.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Resume { get; set; }
        public string Image { get; set; }
        public float Rating { get; set; }
        public DateTime RealeaseDate { get; set; }
    }

    [JsonSerializable(typeof(List<Movie>))]
    internal sealed partial class MovieSerializerContext : JsonSerializerContext
    {

    }
}
