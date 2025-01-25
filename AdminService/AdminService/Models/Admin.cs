using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminService.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminEmail { get; set; }
        [Required]
        public string AdminPassword { get; set; }
        [Required]
        public string AdminPhone { get; set; }

        
        public DateTime CreatedAT { get; set; }= DateTime.Now;

    }
}
