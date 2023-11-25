using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AsiTakibiDto
{
    public class AsiTakibiAddDto
    {      
        public string? YapilanAsininTuru { get; set; } 
        public string? Aciklama { get; set; }
        public DateTime? AsininYapildigiTarih { get; set; }
        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
