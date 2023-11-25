using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.TemizlikTakibiDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemizlikTakibiController : ControllerBase
    {
        private readonly ITemizlikTakibiService _temizlikTakibiService;
        private readonly IMapper _mapper;
        public TemizlikTakibiController(ITemizlikTakibiService temizlikTakibiService , IMapper mapper)
        {
            _temizlikTakibiService = temizlikTakibiService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TemizlikTakipListe()
        {
            var values = _temizlikTakibiService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult TemizlikTakipEkle(TemizlikTakibiAddDto temizlikTakibiAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<TemizlikTakibi>(temizlikTakibiAddDto);
            _temizlikTakibiService.TInsert(values);
            return Ok();
        }

        [HttpDelete]
        public IActionResult TemizlikTakipSil(int id)
        {
            var values = _temizlikTakibiService.TGetByID(id);
            _temizlikTakibiService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult TemizlikTakipDuzenle(TemizlikTakibiUpDto temizlikTakibiUpDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<TemizlikTakibi>(temizlikTakibiUpDto);
            _temizlikTakibiService.TUpdate(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult TemizlikTakipGetir(int id)
        {
            var values = _temizlikTakibiService.TGetByID(id);
            return Ok(values);
        }

    }
}
