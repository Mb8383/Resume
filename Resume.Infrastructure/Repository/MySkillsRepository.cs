using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class MySkillsRepository:IMySkillsRepository
    {
        private RsumeDbContext _context;
        public MySkillsRepository(RsumeDbContext context)
        {
            _context = context;
        }
        public List<MySkills> MySkills()
        {
           return _context.MySkills.ToList();
        }
    }
}
