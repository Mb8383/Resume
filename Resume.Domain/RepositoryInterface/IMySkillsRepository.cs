using Resume.Domain.Models.Entities.MySkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillsRepository
    {
     public List<MySkills> MySkills();

    }
}
