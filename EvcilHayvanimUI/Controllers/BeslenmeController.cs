using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace EvcilHayvanimUI.Controllers
{
    [Authorize]
    public class BeslenmeController : Controller
    {
        private readonly IHttpContextAccessor _http;

        public BeslenmeController(IHttpContextAccessor http)
        {
            _http = http;
        }

        public IActionResult Index()
        {
            var userId = _http.HttpContext.Session.GetInt32("UserId");
            ViewBag.userId = userId;
            return View();
        }

        
        
    }
}
