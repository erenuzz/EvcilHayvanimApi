using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SosyalAktiviteleriDto
{
    public class SosyalAktiviteleriAddDto
    {      
        public bool? OyuncaklarlaIlgilenirmi { get; set; }
        public bool? DisariCikiyormu { get; set; } //eveti seçerse nesıklıklacıkıyor kutuusunu aç
        public string? NeSikliklaCikiyor { get; set; }
        public bool? SeyahetEdermisiniz { get; set; } //eveti seçerse nesıklıklacıkıyorsunuz kutuusunu aç
        public string? NeSikliklaSeyaheteCikiyorsunuz { get; set; }
        public string? HayvaniniziMutluEdenSeyler { get; set; }
        public string? HayvaniniziOfkelendirenSeyler { get; set; }
        public string? OnuSakinlestirmekIcinKullandiginizYontemler { get; set; }
        public DateTime? OyunOynamaZamaniUyarisi { get; set; } //Kullanıcı oyun için uyari alsın
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
