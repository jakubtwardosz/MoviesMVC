using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesMVC.Models
{
    public enum Rating
    {
        [Display(Name = "⭐")]
        ONE = 1,
        [Display(Name = "⭐⭐")]
        TWO = 2,
        [Display(Name = "⭐⭐⭐")]
        THREE = 3,
        [Display(Name = "⭐⭐⭐⭐")]
        FOUR = 4,
        [Display(Name = "⭐⭐⭐⭐⭐")]
        FIVE = 5
    }


    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        [Required]
        [StringLength(120)]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Display(Name = "Gatunek")]
        [Required]
        [StringLength(120)]
        [DataType(DataType.Text)]
        public Genre Genre { get; set; }

        [Display(Name = "Author")]
        [Required]
        [DataType(DataType.Text)]
        public string Author { get; set; }

        [Display(Name = "Opis")]
        [Required]
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Data Premiery")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Box Office")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BoxOffice { get; set; }

        [Display(Name = "Rating")]
        [Required]
        public Rating Rating { get; set; }
    }
}
