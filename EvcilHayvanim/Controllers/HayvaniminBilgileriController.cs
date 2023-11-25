using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.HayvaniminBilgileriDto;
using EntityLayer.Concrete;
using EvcilHayvanim.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HayvaniminBilgileriController : ControllerBase
    {
        private readonly IHayvaniminBilgileriService _hayvaniminBilgileriService;
        private readonly IMapper _mapper;
       
        public HayvaniminBilgileriController(IHayvaniminBilgileriService hayvaniminBilgileriService , IMapper mapper)
        {
            _hayvaniminBilgileriService = hayvaniminBilgileriService;
            _mapper = mapper;           
        }

        [HttpGet]
        public IActionResult HayvanlarimListe(int userId)
        {      
           
            var values = _hayvaniminBilgileriService.TGetList(x=>x.UserId == userId).Include(x=>x.EvcilHayvanlar).Select( x=> new HayvanlarimListe
            {
                Id = x.Id,
                Adi = x.Adi,
                Yasi = x.Yasi,
                SahiplenildigiTarih = x.SahiplenildigiTarih,
                Cinsiyeti = x.Cinsiyeti,
                DogumTarihi = x.DogumTarihi,
                Kilosu = x.Kilosu,               
                HastalikAciklamaveKullandigiIlaclar = x.HastalikAciklamaveKullandigiIlaclar,
                KullanilanTakviyeveVitaminVarmi = x.KullanilanTakviyeveVitaminVarmi,               
                Irki = x.Irki,
                Kisirlastirilmismi = x.Kisirlastirilmismi,
                AyniEvdeYasayanBaskaHayvanVarmi = x.AyniEvdeYasayanBaskaHayvanVarmi,
                TakipCipiVarmi = x.TakipCipiVarmi,               
                UserId = x.UserId,
                EklemeTarihi = x.EklemeTarihi,
                HayvanTürü = x.EvcilHayvanlar.HayvaninAdi,
                hayvanId = x.EvcilHayvanlarId
            });
           
            return Ok(values);
        }



        [HttpPost]
        public IActionResult HayvanlarimEkle([FromForm] HayvaniminBilgileriAddDto hayvaniminBilgileriAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
                       
                       
            var values = _mapper.Map<HayvaniminBilgileri>(hayvaniminBilgileriAddDto);
            _hayvaniminBilgileriService.TInsert(values);
            return Ok();
        }

        [HttpDelete("HayvanlarimSil")]
        public IActionResult HayvanlarimSil(int id)
        {
            var values = _hayvaniminBilgileriService.TGetByID(id);
            _hayvaniminBilgileriService.TDelete(values);
            return Ok();
        }

        [HttpPut("HayvanlarimDuzenle/{id}")]
        public IActionResult HayvanlarimDuzenle(HayvaniminBilgileriUpDto hayvaniminBilgileriUpDto , int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var hayvanBul = _hayvaniminBilgileriService.TGetByID(Id);
            hayvanBul.Id = Id;
            hayvanBul.Adi = hayvaniminBilgileriUpDto.Adi;
            hayvanBul.Yasi = hayvaniminBilgileriUpDto.Yasi;
            hayvanBul.SahiplenildigiTarih = hayvaniminBilgileriUpDto.SahiplenildigiTarih;
            hayvanBul.Cinsiyeti = hayvaniminBilgileriUpDto.Cinsiyeti;
            hayvanBul.DogumTarihi = hayvaniminBilgileriUpDto.DogumTarihi;
            hayvanBul.Kilosu = hayvaniminBilgileriUpDto.Kilosu;
            hayvanBul.HastalikAciklamaveKullandigiIlaclar = hayvaniminBilgileriUpDto.HastalikAciklamaveKullandigiIlaclar;
            hayvanBul.KullanilanTakviyeveVitaminVarmi = hayvaniminBilgileriUpDto.KullanilanTakviyeveVitaminVarmi;
            hayvanBul.Irki = hayvaniminBilgileriUpDto.Irki;
            hayvanBul.Kisirlastirilmismi = hayvaniminBilgileriUpDto.Kisirlastirilmismi;
            hayvanBul.AyniEvdeYasayanBaskaHayvanVarmi = hayvaniminBilgileriUpDto.AyniEvdeYasayanBaskaHayvanVarmi;
            hayvanBul.TakipCipiVarmi = hayvaniminBilgileriUpDto.TakipCipiVarmi;
            hayvanBul.UserId = hayvaniminBilgileriUpDto.UserId;
            hayvanBul.EklemeTarihi = hayvaniminBilgileriUpDto.EklemeTarihi;
            hayvanBul.EvcilHayvanlarId = hayvaniminBilgileriUpDto.EvcilHayvanlarId;
            _mapper.Map<HayvaniminBilgileri>(hayvaniminBilgileriUpDto);
            _hayvaniminBilgileriService.TUpdate(hayvanBul);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult HayvanlarimGetir(int id)
        {
            var values = _hayvaniminBilgileriService.TGetByID(id);
            return Ok(values);
        }
    }
}
