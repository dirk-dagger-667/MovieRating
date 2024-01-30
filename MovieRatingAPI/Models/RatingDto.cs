using System.ComponentModel.DataAnnotations;

namespace MovieRatingAPI.Models
{
    public class RatingDto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Id is an needs to be between 1 and max int value")]
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rating needs to be between 1 and 5")]
        public int Rating { get; set; }
    }
}
