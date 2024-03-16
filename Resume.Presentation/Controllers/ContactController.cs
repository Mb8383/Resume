using Microsoft.AspNetCore.Mvc;
using Resume.Domain.DTO;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;

namespace Resume.Presentation.Controllers
{
    public class ContactController : Controller
    {
        public readonly IContactRepository _contactRepository;
        public ContactController (IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactDTO contactDTO)
        {
            return View();
        }

    }
}
