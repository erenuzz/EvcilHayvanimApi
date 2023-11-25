using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BeslenmeTakibi
    {
        [Key]
        public int Id { get; set; }
        public string? KullandigiMamaTuru { get; set; } //Seçenek sunulacak
        public string? MamaMarkasi { get; set; }
        public string? MamaAromasi { get; set; }
        public int? UygunOlanOgunMiktari { get; set; } //seçim olsun 1,2,3,4,5 gibi
        public string? AlerjikReaksiyonGosterdigiBesinler { get; set; }
        
        public string? SuTuketimOrani { get; set; } //az orta çok
        public DateTime? YemekSaatiUyarisi { get; set; }  //Kullanıcı hayvanının yemek saatinden kaç saat önce uyari almak isityosa o saati seçecek
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
