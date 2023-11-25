using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AsiTakibi
    {
        [Key]
        public int Id { get; set; }
        public string? YapilanAsininTuru { get; set; } //seçenek sunulacak seçeneklere diğer ekklenecek diğeri seçerse açıklama alanı açılacak
        public string? Aciklama { get; set; }
        public DateTime? AsininYapildigiTarih { get; set; }
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
