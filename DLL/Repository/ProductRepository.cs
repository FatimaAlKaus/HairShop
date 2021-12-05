using BLL.Models;
using BLL.Repository;
using DLL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(HairShopDbContext context) : base(context)
        {
        }
        public override IEnumerable<Product> GetAll()
        {
            return Context.Products.Include(x => x.Brand).Include(x => x.Type).AsNoTrackingWithIdentityResolution();
        }
    }
}
