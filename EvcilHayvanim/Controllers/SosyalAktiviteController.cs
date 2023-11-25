using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.SosyalAktiviteleriDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SosyalAktiviteController : ControllerBase
    {
        private readonly ISosyalAktiviteService _sosyalAktiviteService;
        private readonly IMapper _mapper;
        public SosyalAktiviteController(ISosyalAktiviteService sosyalAktiviteService , IMapper mapper)
        {
            _sosyalAktiviteService = sosyalAktiviteService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SosyalAktiviteListe()
        {
            var values = _sosyalAktiviteService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult SosyalAktiviteEkle(SosyalAktiviteleriAddDto sosyalAktiviteleriAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SosyalAktiviteleri>(sosyalAktiviteleriAddDto);
            _sosyalAktiviteService.TInsert(values);
            return Ok();
        }

        [HttpDelete]
        public IActionResult SosyalAktiviteSil(int id)
        {
            var values = _sosyalAktiviteService.TGetByID(id);
            _sosyalAktiviteService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult SosyalAktiviteDuzenle(SosyalAktiviteleriUpDto sosyalAktiviteleriUpDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SosyalAktiviteleri>(sosyalAktiviteleriUpDto);
            _sosyalAktiviteService.TUpdate(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult SosyalAktiviteGetir(int id)
        {
            var values = _sosyalAktiviteService.TGetByID(id);
            return Ok(values);
        }
    }
}
