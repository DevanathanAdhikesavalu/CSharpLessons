using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Movie
    {
        [Key]

        [Range(99, int.MaxValue, ErrorMessage = "ID should start with 99")]
        [Required (ErrorMessage="ID is required")]
        public int MovieId { get; set; }

        [StringLength(20,ErrorMessage ="Name should have max characters of 20")]
        [MinLength(3,ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage ="Name column is must")]
        public string MovieTitle { get; set; }=String.Empty;

        [StringLength(20, ErrorMessage = "Name should have max characters of 20")]
        [MinLength(3, ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage = "Name column is must")]
        public string MovieLanguage { get; set; } = String.Empty;

        [StringLength(20, ErrorMessage = "Name should have max characters of 20")]
        [MinLength(3, ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage = "Name column is must")]
        public string MovieHero { get; set; } = String.Empty;

        [StringLength(20, ErrorMessage = "Name should have max characters of 20")]
        [MinLength(3, ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage = "Name column is must")]
        public string MovieDirector { get; set; } = String.Empty;
        [StringLength(20, ErrorMessage = "Name should have max characters of 20")]
        [MinLength(3, ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage = "Name column is must")]
        public string MusicDirector { get; set; } = String.Empty;

        public DateTime MovieReleaseDate { get; set; }

        [Range(10, double.MaxValue, ErrorMessage = "ID should start with 99")]
        [Required(ErrorMessage = "ID is required")]
        public decimal ProductionCost { get; set; }

        [Range(10, double.MaxValue, ErrorMessage = "ID should start with 99")]
        [Required(ErrorMessage = "ID is required")]
        public decimal BoxOffice { get; set; }

        [StringLength(20, ErrorMessage = "Name should have max characters of 20")]
        [MinLength(3, ErrorMessage = "Name should have atleast three characters")]
        [Required(ErrorMessage = "Name column is must")]
        public string MovieReview { get; set; } = String.Empty;
    }
}
