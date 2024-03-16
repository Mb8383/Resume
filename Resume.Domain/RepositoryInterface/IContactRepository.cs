using Resume.Domain.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IContactRepository
    {
        Task AddContact(Contacts contacts);
    }
}
