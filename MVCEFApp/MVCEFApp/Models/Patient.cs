using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must be between 3 to 20 chars")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 to 20 chars")]
        public string City { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }
}
