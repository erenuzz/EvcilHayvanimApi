using DtoLayer.Dtos.GirisDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanimUI.Controllers
{
    public class GirisController : Controller
    {
        private readonly SignInManager<Kullanicilar> _signInManager;
        private readonly UserManager<Kullanicilar> _userManager;
        private readonly IHttpContextAccessor _http;
        public GirisController(SignInManager<Kullanicilar> signInManager, UserManager<Kullanicilar> userManager, IHttpContextAccessor http)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _http = http;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]       
        public async Task<IActionResult> Index(GirisDto girisDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(girisDto.Email);

                if (user != null && await _userManager.CheckPasswordAsync(user, girisDto.Sifre))
                {
                    var result = await _signInManager.PasswordSignInAsync(user, girisDto.Sifre, false, false);                   
                   
                    if (result.Succeeded)
                    {
                        _http.HttpContext.Session.SetInt32("UserId", user.Id);
                        _http.HttpContext.Session.SetString("UserName", user.UserName);
                        _http.HttpContext.Session.SetString("AdSoyad", user.Isim + " " + user.Soyisim);
                        return Ok(new { message = "Giriş yapıldı" });
                    }
                }
            }

            return BadRequest(new { message = "Giriş başarısız, e-posta veya şifre yanlış." });
        }

           
        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();           
            return RedirectToAction("Index", "Giris");
        }
    }
}
