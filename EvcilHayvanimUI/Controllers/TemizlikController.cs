using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvcilHayvanimUI.Controllers
{
    [Authorize]
    public class TemizlikController : Controller
    {
        private readonly IHttpContextAccessor _http;

        public TemizlikController(IHttpContextAccessor http)
        {
            _http = http;
        }

        public IActionResult Index()
        {
            var userId = _http.HttpContext.Session.GetInt32("UserId");
            ViewBag.UserId = userId;
            return View();
        }
    }
}
