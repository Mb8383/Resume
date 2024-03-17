using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Domain.Models.Entities.Experience;
using Resume.Presentation.Models;
using Resume.Domain.Models.Entities.MySkills;
using System.Diagnostics;
using Resume.Domain.DTO.Siteside.Home_Index;
using Resume.Domain.RepositoryInterface;
using Resume.Application.Services.Interface;


namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEducationService _educationService;
        private readonly IMySkillsService _mySkillsService;
        private readonly IExperienceService _experienceService;
        public HomeController(IMySkillsService mySkillsService, IExperienceService experienceService, IEducationService educationService)
        {
            _mySkillsService = mySkillsService;
            _experienceService = experienceService;
            _educationService = educationService;
        }

        public async Task< IActionResult> Index()
        {
            #region MySKils
            List<MySkills> MySkills = _mySkillsService.MySkills();

			#endregion
			#region Educaties
           List<Educaties> Educaties = await _educationService.GetAllAnEducaties();
			#endregion
			#region Experience
            List<Experience> Experience = _experienceService.Experience();
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
