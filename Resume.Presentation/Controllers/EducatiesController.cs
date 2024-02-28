using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Presentation.Models.Entities.Educaties;
using Resume.Presentation.Models.ResumeDbContext;



namespace Resume.Presentation.Controllers
{
    public class EducatiesController : Controller
    {
        #region CTOR
        private readonly IEducationService _educationService;
        public EducatiesController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion

        [HttpGet]
        public async Task <IActionResult> listofEducaties()
        {
            List<Educaties>educaties=await _educationService.GetAllAnEducaties();
            return View(educaties);

        }
        [HttpGet]
        public async Task Creat(Educaties educaties)
        {
            await _educationService.CreatAnEducaties(educaties);

        }
    }
}
