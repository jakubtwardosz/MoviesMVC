using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesMVC.Models
{
    public enum Rating
    {
        ONE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5
    }
    public class Movie
    {
        public static int AutoID = 1;
        public int Id { get; }

        [Display(Name = "Tytuł")]
        [Required]
        [StringLength(120)]
        [DataType(DataType.Text)]
        public string Title { get; set; }

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

        public Movie()
        {
            this.Id = AutoID++;
        }
    }
}
