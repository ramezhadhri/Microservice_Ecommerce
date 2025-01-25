using ProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductService.Data
{
    public class DbContextClass:DbContext

    {
        protected readonly IConfiguration configuration;
        public DbContextClass (IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
