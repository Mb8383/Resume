using Microsoft.AspNetCore.Mvc;
using Resume.Domain.DTO;
using Resume.Domain.RepositoryInterface;
using Resume.Domain.Entities;
using Resume.Domain.Entities.Contact;
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
            Contacts contacts = new Contacts()
            {
                Name = contactDTO.Name,
                PhoneNumber = contactDTO.PhoneNumber,
                Message = contactDTO.Message,
            };
           _contactRepository.AddContact(contacts);
            return View();
        }

    }
}
