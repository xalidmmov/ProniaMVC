using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
