using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.BeslenmeTakibiDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net.Mail;
using System.Net;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeslenmeTakibiController : ControllerBase
    {
        private readonly IBeslenmeTakibiService _beslenmeTakibiService;
        private readonly IMapper _mapper;
        public BeslenmeTakibiController(IBeslenmeTakibiService beslenmeTakibiService , IMapper mapper)
        {
            _beslenmeTakibiService = beslenmeTakibiService;
            _mapper = mapper;
        }
       

        [HttpGet("BeslenmeListe")]
        public IActionResult BeslenmeListe(int userId)
        {
            var values = _beslenmeTakibiService.TGetList(x=>x.UserId == userId);
            return Ok(values);
        }

        [HttpPost("BeslenmeEkle")]
        public IActionResult BeslenmeEkle([FromForm]BeslenmeTakibiAddDto beslenmeTakibiAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<BeslenmeTakibi>(beslenmeTakibiAddDto);
            _beslenmeTakibiService.TInsert(values);
            return Ok();
        }

        [HttpDelete("Sil")]
        public IActionResult BeslenmeSil(int id)
        {
            var values = _beslenmeTakibiService.TGetByID(id);
            _beslenmeTakibiService.TDelete(values);
            return Ok();
        }

        [HttpPut("BeslenmeDuzenle/{id}")]
        public IActionResult BeslenmeDuzenle(BeslenmeTakibiUpDto beslenmeTakibiUpDto , int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var beslenmeBul = _beslenmeTakibiService.TGetByID(id);
            beslenmeBul.KullandigiMamaTuru = beslenmeTakibiUpDto.KullandigiMamaTuru;
            beslenmeBul.MamaMarkasi = beslenmeTakibiUpDto.MamaMarkasi;
            beslenmeBul.MamaAromasi = beslenmeTakibiUpDto.MamaAromasi;
            beslenmeBul.UygunOlanOgunMiktari = beslenmeTakibiUpDto.UygunOlanOgunMiktari;
            beslenmeBul.AlerjikReaksiyonGosterdigiBesinler = beslenmeTakibiUpDto.AlerjikReaksiyonGosterdigiBesinler;
            beslenmeBul.SuTuketimOrani = beslenmeTakibiUpDto.SuTuketimOrani;
            if(beslenmeTakibiUpDto.YemekSaatiUyarisi == null)
            {
                beslenmeBul.YemekSaatiUyarisi = beslenmeTakibiUpDto.YemekSaatiUyarisi;
            }
            else
            {
                beslenmeBul.YemekSaatiUyarisi = beslenmeBul.YemekSaatiUyarisi;
            }
            beslenmeBul.UserId = beslenmeTakibiUpDto.UserId;
            beslenmeBul.EklemeTarihi = beslenmeBul.EklemeTarihi;
            _mapper.Map<BeslenmeTakibi>(beslenmeTakibiUpDto);
            _beslenmeTakibiService.TUpdate(beslenmeBul);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BeslenmeGetir(int id)
        {
            var values = _beslenmeTakibiService.TGetByID(id);
            return Ok(values);
        }

       

    }
}
