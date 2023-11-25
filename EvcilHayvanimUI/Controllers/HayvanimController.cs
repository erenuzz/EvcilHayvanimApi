using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace EvcilHayvanimUI.Controllers
{
    [Authorize]
    public class HayvanimController : Controller
    {
        private readonly IHttpContextAccessor _http;
        private readonly EvcilDbContext _c;
        public HayvanimController(IHttpContextAccessor http , EvcilDbContext c)
        {
            _http = http;
            _c = c;
        }

      
        public IActionResult Index()
        {
            var userId = _http.HttpContext.Session.GetInt32("UserId");      
            ViewBag.userId = userId;
            return View();
        }
       
        public IActionResult Hayvanlar()
        {
            var values = _c.EvcilHayvanlar.ToList();
            return Json(values);
        }

    }
}
