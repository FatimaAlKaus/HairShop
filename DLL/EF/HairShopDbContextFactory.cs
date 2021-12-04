using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.EF
{
    public class HairShopDbContextFactory : IDesignTimeDbContextFactory<HairShopDbContext>
    {
        public HairShopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HairShopDbContext>();
            builder.UseSqlServer(args[0]);
            return new HairShopDbContext(builder.Options);
        }
    }
}