using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBeslenmeTakibiDal : GenericRepository<BeslenmeTakibi>, IBeslenmeTakipDal
    {
        public EfBeslenmeTakibiDal(EvcilDbContext evcilDbContext) : base(evcilDbContext)
        {
        }
    }
}
