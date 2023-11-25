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
    public class SosyalAktiviteManager : ISosyalAktiviteService
    {
        private readonly ISosyalAktiviteDal _sosyalAktiviteDal;

        public SosyalAktiviteManager(ISosyalAktiviteDal sosyalAktiviteDal)
        {
            _sosyalAktiviteDal = sosyalAktiviteDal;
        }

        public void TDelete(SosyalAktiviteleri t)
        {
           _sosyalAktiviteDal.Delete(t);
        }

        public SosyalAktiviteleri TGetByID(int id)
        {
           return _sosyalAktiviteDal.GetByID(id);
        }

        public IQueryable<SosyalAktiviteleri> TGetList(Expression<Func<SosyalAktiviteleri, bool>>? predicate = null)
        {
            return _sosyalAktiviteDal.GetList(predicate);
        }

        public void TInsert(SosyalAktiviteleri t)
        {
            _sosyalAktiviteDal.Insert(t);
        }

        public void TUpdate(SosyalAktiviteleri t)
        {
           _sosyalAktiviteDal.Update(t);
        }
    }
}
