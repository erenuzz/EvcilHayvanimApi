using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.HayvaniminBilgileriDto
{
    public class HayvaniminBilgileriUpDto
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Yasi { get; set; }
        public DateTime? SahiplenildigiTarih { get; set; }
        public string? Cinsiyeti { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? Kilosu { get; set; }
        public string? HastalikAciklamaveKullandigiIlaclar { get; set; }
        public string? KullanilanTakviyeveVitaminVarmi { get; set; }
        public string? Irki { get; set; } //seçenek için araştır 
        public bool? Kisirlastirilmismi { get; set; }
        public bool? AyniEvdeYasayanBaskaHayvanVarmi { get; set; }
        public bool? TakipCipiVarmi { get; set; }
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int EvcilHayvanlarId { get; set; }

    }
}
