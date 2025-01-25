using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UserServices.Models;
namespace UserServices.Data
{
    public class DbContextClasss: DbContext
    {
         protected readonly IConfiguration configuration;
        
        public DbContextClasss(IConfiguration configuration) { 
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
       public DbSet<User> Users { get; set; }


    }
}
