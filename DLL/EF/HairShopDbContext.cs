using BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace DLL.EF
{
    public class HairShopDbContext : DbContext
    {
        public HairShopDbContext(DbContextOptions<HairShopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<HairType> HairTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
