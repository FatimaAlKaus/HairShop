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
    public class BaseRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly HairShopDbContext _context;
        protected HairShopDbContext Context => _context;
        public BaseRepository(HairShopDbContext context)
        {
            _context = context;
        }
        public virtual T Create(T entity)
        {
            var entry = _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entry.Entity;
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Update(T entity)
        {
            var entry = _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entry.Entity;
        }
    }
}
