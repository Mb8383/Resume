using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
