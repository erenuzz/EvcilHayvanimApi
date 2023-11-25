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
    public class HayvaniminBilgileriManager : IHayvaniminBilgileriService
    {
        private readonly IHayvaniminBilgileriDal _hayvaniminBilgileriDal;

        public HayvaniminBilgileriManager(IHayvaniminBilgileriDal hayvaniminBilgileriDal)
        {
            _hayvaniminBilgileriDal = hayvaniminBilgileriDal;
        }

        public void TDelete(HayvaniminBilgileri t)
        {
           _hayvaniminBilgileriDal.Delete(t);
        }

        public HayvaniminBilgileri TGetByID(int id)
        {
           return _hayvaniminBilgileriDal.GetByID(id);
        }

        public IQueryable<HayvaniminBilgileri> TGetList(Expression<Func<HayvaniminBilgileri, bool>>? predicate = null)
        {
            return _hayvaniminBilgileriDal.GetList(predicate);
        }

       
        public void TInsert(HayvaniminBilgileri t)
        {
           _hayvaniminBilgileriDal.Insert(t);
        }

        public void TUpdate(HayvaniminBilgileri t)
        {
           _hayvaniminBilgileriDal.Update(t);
        }


    }
}
