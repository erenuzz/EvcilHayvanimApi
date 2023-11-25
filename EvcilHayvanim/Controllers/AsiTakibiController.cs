using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.AsiTakibiDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiTakibiController : ControllerBase
    {
        private readonly IAsiTakibiService _asiTakibiService;
        private readonly IMapper _mapper;
        public AsiTakibiController(IAsiTakibiService asiTakibiService , IMapper mapper)
        {
            _asiTakibiService = asiTakibiService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AsiListe()
        {
            var values = _asiTakibiService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AsiEkle(AsiTakibiAddDto asiTakibiAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<AsiTakibi>(asiTakibiAddDto);
             _asiTakibiService.TInsert(values);          
            return Ok();            
        }

        [HttpDelete]
        public IActionResult AsiSil(int id)
        {
            var values = _asiTakibiService.TGetByID(id);
            _asiTakibiService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult AsiDuzenle(AsiTakibiUpDto asiTakibiUpDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<AsiTakibi>(asiTakibiUpDto);
            _asiTakibiService.TUpdate(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult AsiGetir(int id)
        {
            var values = _asiTakibiService.TGetByID(id);
            return Ok(values);
        }

    }
}
