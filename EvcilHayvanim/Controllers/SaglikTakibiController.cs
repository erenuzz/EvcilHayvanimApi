using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.SaglikTakibiDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaglikTakibiController : ControllerBase
    {
        private readonly ISaglikTakibiService _saglikTakibiService;
        private readonly IMapper _mapper;
        public SaglikTakibiController(ISaglikTakibiService saglikTakibiService , IMapper mapper)
        {
            _saglikTakibiService = saglikTakibiService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SaglikTakibiListe()
        {
            var values = _saglikTakibiService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult SaglikTakibiEkle(SaglikTakibiAddDto saglikTakibiAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SaglikTakibi>(saglikTakibiAddDto);
            _saglikTakibiService.TInsert(values);
            return Ok();
        }

        [HttpDelete]
        public IActionResult SaglikTakibiSil(int id)
        {
            var values = _saglikTakibiService.TGetByID(id);
            _saglikTakibiService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult SaglikTakibiDuzenle(SaglikTakibiUpDto saglikTakibiUpDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<SaglikTakibi>(saglikTakibiUpDto);
            _saglikTakibiService.TUpdate(values);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult SaglikTakibiGetir(int id)
        {
            var values = _saglikTakibiService.TGetByID(id);
            return Ok(values);
        }
    }
}
