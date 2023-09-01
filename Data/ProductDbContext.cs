using IWantToBuy.Models;
using Microsoft.EntityFrameworkCore;

namespace IWantToBuy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Produts { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    }
}