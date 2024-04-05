using Microsoft.AspNetCore.Mvc;

namespace StajProje.Areas.Admin.Controllers
{
    public class WidgetController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
