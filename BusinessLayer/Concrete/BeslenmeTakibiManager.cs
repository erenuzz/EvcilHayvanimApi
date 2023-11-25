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
    public class BeslenmeTakibiManager : IBeslenmeTakibiService
    {
        private readonly IBeslenmeTakipDal _beslenmeTakibiDal;

        public BeslenmeTakibiManager(IBeslenmeTakipDal beslenmeTakibiDal)
        {
            _beslenmeTakibiDal = beslenmeTakibiDal;
        }

        public void TDelete(BeslenmeTakibi t)
        {
            _beslenmeTakibiDal.Delete(t);
        }

        public BeslenmeTakibi TGetByID(int id)
        {
           return _beslenmeTakibiDal.GetByID(id);
        }

        public IQueryable<BeslenmeTakibi> TGetList(Expression<Func<BeslenmeTakibi, bool>>? predicate = null)
        {
           return _beslenmeTakibiDal.GetList(predicate);
        }

        public void TInsert(BeslenmeTakibi t)
        {
          _beslenmeTakibiDal.Insert(t);
        }

        public void TUpdate(BeslenmeTakibi t)
        {
           _beslenmeTakibiDal.Update(t);
        }
    }
}
