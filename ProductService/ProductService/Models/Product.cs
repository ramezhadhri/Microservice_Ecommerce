using ProductService.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    public string ProductName { get; set; }

    [MaxLength(500)]
    public string ProductDescription { get; set; }

    [Range(0.01, 10000)]
    public decimal BuyPrice { get; set; }
    [Range(0, 100)]
    public double DiscountPercentage { get; set; }
    
    public decimal DiscountedPrice { get; set; }
   
    [Range(0.01, 10000)]
    public decimal SellPrice { get; set; }

    [Range(0, int.MaxValue)]
    public int ProductStock { get; set; }
    
    public int CategoryId { get; set; }
    

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
   
}
