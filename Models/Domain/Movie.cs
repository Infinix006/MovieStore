using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? ReleaseYear { get; set; }


        public string? MovieImage { get; set; } // stores movie image name with extension i.e. image.jpeg

        [Required]
        public string? Cast { get; set; }

        [Required]
        public string? Director { get; set; }
    }
}
