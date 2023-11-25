﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SaglikTakibiDto
{
    public class SaglikTakibiAddDto
    {      
        public bool? DuzenliOlarakGidilenVeterinerVarmi { get; set; }
        public string? VeterinerAdi { get; set; }
        public string? Soyadi { get; set; }
        public string? KlinikTelNo { get; set; }
        public string? KlinikAdi { get; set; }
        public string? KlinikAdres { get; set; }
        public string? HayvaninizinKiloDurumu { get; set; } //seçenek suncaz
        public bool? KalitsalHastalik { get; set; }
        public string? KalitsalHastalikAciklama { get; set; }
        public bool? GeciciHastalikVarmi { get; set; }
        public string? GeciciHastalikAciklama { get; set; }
        public string? EvcilHayvaninizdaGozlemlediginizFarklilik { get; set; }

        public int UserId { get; set; }
        public DateTime EklemeTarihi { get; set; }
    }
}
