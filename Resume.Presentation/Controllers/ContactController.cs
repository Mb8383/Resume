using Microsoft.AspNetCore.Mvc;
using Resume.Domain.DTO;
using Resume.Domain.RepositoryInterface;
using Resume.Domain.Entities;
using Resume.Domain.Entities.Contact;
using Resume.Application.Services.Interface;
namespace Resume.Presentation.Controllers
{
    public class ContactController : Controller
    {
        public readonly IContactService _contactRepository;
        public ContactController (IContactService contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactDTO contactDTO)
        {
         await   _contactRepository.AddContact(contactDTO);
            return View();
        }

    }
}
