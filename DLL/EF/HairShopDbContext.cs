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
    }
}
