using BLL.Models;
using BLL.Repository;
using DLL.EF;
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
    }
}
