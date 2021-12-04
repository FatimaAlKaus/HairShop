using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
