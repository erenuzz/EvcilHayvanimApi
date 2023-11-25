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
    public class TemizlikTakibiManager : ITemizlikTakibiService
    {
        private readonly ITemizlikTakibiDal _temizlikTakibiDal;

        public TemizlikTakibiManager(ITemizlikTakibiDal temizlikTakibiDal)
        {
            _temizlikTakibiDal = temizlikTakibiDal;
        }

        public void TDelete(TemizlikTakibi t)
        {
           _temizlikTakibiDal.Delete(t);
        }

        public TemizlikTakibi TGetByID(int id)
        {
            return _temizlikTakibiDal.GetByID(id);
        }

        public IQueryable<TemizlikTakibi> TGetList(Expression<Func<TemizlikTakibi, bool>>? predicate = null)
        {
            return _temizlikTakibiDal.GetList(predicate);
        }

        public void TInsert(TemizlikTakibi t)
        {
           _temizlikTakibiDal.Insert(t);
        }

        public void TUpdate(TemizlikTakibi t)
        {
           _temizlikTakibiDal.Update(t);
        }
    }
}
