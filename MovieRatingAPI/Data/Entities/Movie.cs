using System.ComponentModel.DataAnnotations;

namespace MovieRatingAPI.Data.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Resume { get; set; }
        [Required]
        public string? Image { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string? Tags { get; set; }
        public string? Starring { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
