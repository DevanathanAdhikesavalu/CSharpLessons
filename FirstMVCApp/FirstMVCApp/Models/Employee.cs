using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(1000, int.MaxValue, ErrorMessage = " EmployeeID must have at least 1 ")]
        [Required(ErrorMessage = "EmployeeID is Required")]
        public int EmpID { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String EmpName { set; get; } = string.Empty;


        [Range(1,int.MaxValue, ErrorMessage = "Salary amount should get more than 1000 ")]
        [Required(ErrorMessage = "Book Name is Required")]
        public Decimal EmpSalary { set; get; }

        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String EmpCity { get; set; } = string.Empty;

    }

}
