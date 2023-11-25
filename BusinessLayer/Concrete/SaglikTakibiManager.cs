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
    public class SaglikTakibiManager : ISaglikTakibiService
    {
        private readonly ISaglikTakibiDal _saglikTakibiDal;

        public SaglikTakibiManager(ISaglikTakibiDal saglikTakibiDal)
        {
            _saglikTakibiDal = saglikTakibiDal;
        }

        public void TDelete(SaglikTakibi t)
        {
           _saglikTakibiDal.Delete(t);
        }

        public SaglikTakibi TGetByID(int id)
        {
            return _saglikTakibiDal.GetByID(id);
        }

        public IQueryable<SaglikTakibi> TGetList(Expression<Func<SaglikTakibi, bool>>? predicate = null)
        {
            return _saglikTakibiDal.GetList(predicate);
        }

        public void TInsert(SaglikTakibi t)
        {
           _saglikTakibiDal.Insert(t);
        }

        public void TUpdate(SaglikTakibi t)
        {
            _saglikTakibiDal.Update(t);
        }
    }
}
