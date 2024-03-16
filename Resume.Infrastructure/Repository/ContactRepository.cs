using Resume.Domain.Entities.Contact;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class ContactRepository : IContactRepository
    {
        private RsumeDbContext _context;
        public ContactRepository(RsumeDbContext context)
        {
            _context = context;
        }
        public async Task AddContact(Contacts contacts)
        {
        _context.Add(contacts);
        }
    }
}
