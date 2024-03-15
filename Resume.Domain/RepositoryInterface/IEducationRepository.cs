using Resume.Domain.Models.Entities.Educaties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IEducationRepository
    {
     public List<Educaties> Educaties();
    }
}
