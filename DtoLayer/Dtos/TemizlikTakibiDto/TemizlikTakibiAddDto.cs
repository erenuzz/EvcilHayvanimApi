using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.TemizlikTakibiDto
{
    public class TemizlikTakibiAddDto
    {      
        public string TirnaklariNeSikliklaKesiyorsunuz { get; set; } //seçenekleri hergün , haftada 1,2 ayda 1,2 , 2 ayda bir , hiç
        public string AgizBakimiNeSikliklaYapiliyor { get; set; } //seçenekleri hergün , haftada 1,2 ayda 1,2 , 2 ayda bir , hiç
        public string KulakTemizligiNeSikliklaYapiliyor { get; set; } //seçenekleri hergün , haftada 1,2 ayda 1,2 , 2 ayda bir , hiç
        public string GenelTemizlikTuru { get; set; } //seçenek su ile yada kuru şampuan
        public string NeSikliklaYikiyorsunuz { get; set; } //seçenekleri hergün , haftada 1,2 ayda 1,2 , 2 ayda bir , hiç
        public string NeSikliklaTuyleriniTararsiniz { get; set; } //seçenekler  //seçenekleri hergün , haftada 1,2 ayda 1,2 , hiç
        public string NeSikliklaPatiBakimiYapiyorsunuz { get; set; }  //seçenekler  //seçenekleri hergün , haftada 1,2 ayda 1,2 , hiç
        public DateTime BakimTakipUyarisi { get; set; }//Kullanıcı hayvanı için hangi tarihlerde bakım bildirimi almak istiyosa onun saatini seçecek
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
