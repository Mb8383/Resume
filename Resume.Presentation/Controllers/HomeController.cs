using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Domain.Models.Entities.Experience;
using Resume.Presentation.Models;
using Resume.Domain.Models.Entities.MySkills;
using System.Diagnostics;
using Resume.Domain.DTO.Siteside.Home_Index;
using Resume.Domain.RepositoryInterface;


namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEducationRepository _educationRepository;
        private readonly IMySkillsRepository _mySkillsRepository;
        private readonly IExperinceRepository _experinceRepository;
        public HomeController(IMySkillsRepository mySkillsRepository, IExperinceRepository experinceRepository, IEducationRepository educationRepository)
        {
            _mySkillsRepository = mySkillsRepository;
            _experinceRepository = experinceRepository;
            _educationRepository = educationRepository;
        }

        public async Task< IActionResult> Index()
        {
            #region MySKils
            List<MySkills> MySkills = _mySkillsRepository.MySkills();

			#endregion
			#region Educaties
           List<Educaties> Educaties = _educationRepository.Educaties();
			#endregion
			#region Experience
            List<Experience> Experience =_experinceRepository.Experience();
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
