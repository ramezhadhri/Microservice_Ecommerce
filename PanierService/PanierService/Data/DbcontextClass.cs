using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PanierService.Models;

namespace PanierService.Data
{
    public class DbcontextClass:DbContext
    {
        protected  readonly IConfiguration Configuration;
        public DbcontextClass(IConfiguration configuration)
        {
            this.Configuration = Configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString(""));
        }
        DbSet<Panier> Paniers { get; set; }
    }
}
