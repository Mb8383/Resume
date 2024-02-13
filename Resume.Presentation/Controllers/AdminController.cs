using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
	public class AdminController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]	
		public IActionResult Index(string Email,string pasword)
		{
			return View();
		}
	}
}
