using DtoLayer.Dtos.KayitDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanimUI.Controllers
{
    public class KayitController : Controller
    {

        private readonly UserManager<Kullanicilar> _userManager;

        public KayitController(UserManager<Kullanicilar> userManager)
        {
            _userManager = userManager;
        }

        //[HttpGet("Liste")]
        //public IActionResult KullaniciListe()
        //{
        //    try
        //    {
        //        var values = _userManager.Users.ToList();
        //        return Ok(values);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest(new { message = "Yüklenirken bir hata oluştu" });
        //    }

        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(YeniKayitDto yeniKayitDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { message = "Kayıt oluşturulamadı. Lütfen tüm bilgileri girdiğinizden emin olun." });
                }

                var kullanici = new Kullanicilar()
                {
                    Isim = yeniKayitDto.Isim,
                    Soyisim = yeniKayitDto.Soyisim,
                    PhoneNumber = yeniKayitDto.TelefonNumarasi,
                    Email = yeniKayitDto.Mail,
                    UserName = yeniKayitDto.KullaniciAdi,
                    EklemeTarihi = DateTime.Now,
                };
                var mailcontrol = _userManager.Users.Where(x => x.Email == yeniKayitDto.Mail).Count();
                if (mailcontrol > 0)
                {
                    return BadRequest("Sistemde kayıtlı olan bir email hesabı ile tekrar kayıt olamazsınız.");
                }

                var result = await _userManager.CreateAsync(kullanici, yeniKayitDto.Sifre);
                if (result.Succeeded)
                    return Ok(new { message = "Yeni kayıt başarılı bir şekilde oluşturuldu." });
                else
                    return BadRequest(new { message = "Kayıt oluşturulamadı.Lütfen tekrar deneyin." });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

    }
}
