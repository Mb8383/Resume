using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Domain.Models.Entities.Experience;
using Resume.Presentation.Models;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Presentation.Models.ResumeDbContext;
using System.Diagnostics;
using Resume.Domain.DTO.Siteside.Home_Index;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
		private RsumeDbContext _context;
		public HomeController(RsumeDbContext context)
		{
			_context = context;
		}

		public async Task< IActionResult> Index()
        {
            #region MySKils
           List<MySkills> MySkills = await _context.MySkills.ToListAsync();

			#endregion
			#region Educaties
           List<Educaties> Educaties = await _context.Educaties.ToListAsync();
			#endregion
			#region Experience
            List<Experience> Experience = await _context.Experience.ToListAsync();
			#endregion
			#region viewBag
			//ViewBag.MySkills = MySkills;
			//ViewBag.Educaties = Educaties;
			//ViewBag.Experience = Experience;
			#endregion
			#region HomemodelIndex
			HomeIndexModelDTO model = new HomeIndexModelDTO();
			model.MySkills = MySkills;	
			model.Educaties = Educaties;
			model.Experiences = Experience;
			#endregion
			return View(model);
		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
