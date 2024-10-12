using Microsoft.AspNetCore.Mvc;

namespace Fs.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
