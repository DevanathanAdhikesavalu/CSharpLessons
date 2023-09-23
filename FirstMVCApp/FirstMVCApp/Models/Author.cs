using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Author 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(3, 25, ErrorMessage = " AuthorID must have at least 1 ")]
        [Required(ErrorMessage = "AuthorID is Required")]
        public int AuthorID { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String AuthorName { set; get; }

        public DateTime AuthorDOB { set; get; }
        [Range(1, 1000000, ErrorMessage = "total books must have at least 1 ")]
        [Required(ErrorMessage = "Book Name is Required")]
        public int NoOfBooksPublished { set; get; }

        [StringLength(25, ErrorMessage = "RoyaltyCompany must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "RoyaltyCompany must have at least 3 chars")]
        [Required(ErrorMessage = "Author DOB is Required")]
        public String RoyaltyCompany { set; get; }

    }

}