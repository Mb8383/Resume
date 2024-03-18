using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;

namespace Resume.Presentation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EducationController : Controller
    {
        #region Ctor
        private readonly IEducationService _educationService;
        public EducationController (IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion
        #region List Of Education
        [HttpGet]
        public async Task<IActionResult> ListOfEducations()
        {
            var model = _educationService.GetAllAnEducaties;
            return View(model);
        }
        #endregion
        #region Create An Education

        #endregion
        #region Edite an Education

        #endregion
        #region Delete an Education

        #endregion
    }
}
