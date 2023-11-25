using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly EvcilDbContext _c;

        public GenericRepository(EvcilDbContext c)
        {
            _c = c;
        }

        public void Delete(T t)
        {
            _c.Remove(t);
            _c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _c.Set<T>().ToList();
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            var result = _c.Set<T>().AsNoTracking().AsQueryable();
            if(predicate != null)            
                result = result.Where(predicate);
            return result;
        }

        public void Insert(T t)
        {
           _c.Add(t);
            _c.SaveChanges();
        }

        public void Update(T t)
        {
            _c.Update(t);
            _c.SaveChanges();
        }
    }
}
