using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AsiTakibiManager : IAsiTakibiService
    {
        private readonly IAsiTakipDal _asiTakipDal;

        public AsiTakibiManager(IAsiTakipDal asiTakipDal)
        {
            _asiTakipDal = asiTakipDal;
        }

        public void TDelete(AsiTakibi t)
        {
           _asiTakipDal.Delete(t);
        }

        public AsiTakibi TGetByID(int id)
        {
           return _asiTakipDal.GetByID(id);
        }

        public IQueryable<AsiTakibi> TGetList(Expression<Func<AsiTakibi, bool>>? predicate=null)
        {
            return _asiTakipDal.GetList(predicate);
        }

        public void TInsert(AsiTakibi t)
        {
           _asiTakipDal.Insert(t);
        }

        public void TUpdate(AsiTakibi t)
        {
           _asiTakipDal.Update(t);
        }
    }
}
