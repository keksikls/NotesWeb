using Microsoft.AspNetCore.Mvc;

namespace Notespr.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
