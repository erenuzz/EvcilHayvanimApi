using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanicilar:IdentityUser<int>
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime EklemeTarihi { get; set; }


    }
}
