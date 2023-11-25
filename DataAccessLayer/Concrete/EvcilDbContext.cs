using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EvcilDbContext:IdentityDbContext<Kullanicilar , KullaniciRol , int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connection string");
                   
        }
        public DbSet<AsiTakibi> asiTakibis { get; set; }
        public DbSet<BeslenmeTakibi> beslenmeTakibis { get; set; }
        public DbSet<HayvaniminBilgileri> hayvaniminBilgileris { get; set; }
        public DbSet<SaglikTakibi> saglikTakibis { get; set; }
        public DbSet<SosyalAktiviteleri> sosyalAktiviteleris { get; set; }
        public DbSet<TemizlikTakibi> temizlikTakibis { get; set; }
        public DbSet<EvcilHayvanlar> EvcilHayvanlar { get; set; }
    }
}
