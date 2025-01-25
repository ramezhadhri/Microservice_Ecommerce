using Microsoft.EntityFrameworkCore;
using AdminService.Models;

namespace AdminService.Data
{
    public class DbContextClassy:DbContext
    {
        protected readonly IConfiguration configuration;
        public DbContextClassy (IConfiguration configuration)
        {
           this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Admin> Admins { get; set; }

    }
}
