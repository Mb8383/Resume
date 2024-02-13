using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Resume.Presentation.Models.Entities.Educaties;
using Resume.Presentation.Models.ResumeDbContext;


namespace Resume.Presentation.Controllers
{
    public class EducatiesController : Controller
    {


        private RsumeDbContext _context;
        public EducatiesController(RsumeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult listofEducaties()
        {
            List<Educaties> educaties = _context.Educaties.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult CreatAnEducaties()
        {
            Educaties educaties = new();
            educaties.EducatiesTitle = "dskasmdnb";
            educaties.EducatiesDuration = "2000";
            educaties.EducatiesDescription = "Description";
            _context.Add(educaties);
            _context.SaveChanges();
            return View();
        }
    }
}
