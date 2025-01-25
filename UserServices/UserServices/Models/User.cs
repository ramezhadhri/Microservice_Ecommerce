using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserServices.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
       
        public string UserName { get; set; }

        [Required]
        
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        
        public string PasswordConfirmed { get; set; }

      
        public string PhoneNumber { get; set; } 

        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? LastLogin { get; set; }
    }
}
