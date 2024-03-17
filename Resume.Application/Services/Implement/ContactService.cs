

using Resume.Application.Services.Interface;
using Resume.Domain.DTO;
using Resume.Domain.Entities.Contact;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Application.Services.Implement
{
    public class ContactService:IContactService
    {
        public readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task AddContact(ContactDTO contactDTO)
        {
            Contacts contacts = new Contacts()
            {
                Name = contactDTO.Name,
                PhoneNumber = contactDTO.PhoneNumber,
                Message = contactDTO.Message,
            };
            await _contactRepository.AddContact(contacts);
        }
    }
}
